const mongoose = require('mongoose');
const encryption = require('./../utilities/encryption');

let userSchema = mongoose.Schema({
    email: {
        type: mongoose.Schema.Types.String,
        required: true,
        unique: true
    },
    passwordHash: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    fullName: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    roles: [{
        type: mongoose.Schema.Types.String
    }],
    salt: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    articles: {
        type: mongoose.Schema.Types.ObjectId,
        ref: 'Article'
    }
}, {
    usePushEach: true
});


userSchema.method({
    authenticate: function (password) {
        let inputPasswordHash = encryption.hashPassword(password, this.salt);
        let isSamePasswordHash = inputPasswordHash === this.passwordHash;
        return isSamePasswordHash;
    },

    isAuthor: function (article) {
        if (!article) {
            return false;
        }

        let isAuthor = article.author.equals(this.id);

        return isAuthor;
    },

    isInRole: function (role) {
        return this.roles.indexOf(role) !== -1;
    }
});

const User = mongoose.model('User', userSchema);

module.exports = User;

User.seedAdmin = async () => {
    try {
        let users = await User.find();
        if (users.length > 0) return;
        const salt = encryption.generateSalt();
        const passwordHash = encryption.hashPassword('admin', salt);
        return User.create({
            salt,
            email: 'admin@gmail.com',
            passwordHash,
            fullName: 'Admin Adminov',
            roles: ['Admin']
        });
    } catch (e) {
        console.log(e);
    }
};