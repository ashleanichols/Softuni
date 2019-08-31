$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('#/home', function() {
            this.loggedIn = !!sessionStorage.getItem('authtoken');
            this.username = sessionStorage.getItem('username');

            this.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            }).then(function(){
        
                this.partial('/templates/home/home.hbs');
            });
        });

        this.get('#/about', function() {
            this.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            }).then(function(){
        
                this.partial('/templates/about/about.hbs');
            });
        });

        this.get('#/login', function() {
            this.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                loginForm: 'templates/login/loginForm.hbs'
            }).then(function(){
        
                this.partial('/templates/login/loginPage.hbs');
            });
        });

        this.get('#/logout', async function() {
            let result = await auth.logout();
            sessionStorage.clear();
            this.redirect('#/home');
        });

        this.get('#/register', function() {
            this.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                registerForm: 'templates/register/registerForm.hbs'
            }).then(function(){
        
                this.partial('/templates/register/registerPage.hbs');
            });
        });

        this.post('#/register', function(context) {
            let that = this;
            let {username, password, repeatPassword} = context.params;         

            auth.register(username, password, repeatPassword)
            .then(function(response){                
                auth.saveSession(response);
                auth.showInfo('Registered Successfully');
                that.redirect('#/home');
            });
        });        
    });

    app.run('#/home');
});