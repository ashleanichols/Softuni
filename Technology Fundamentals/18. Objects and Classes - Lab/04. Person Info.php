<?php
    class Person 
    {
        private $firstName;
        private $lastName;
        private $age;
        
        public function getFirstName() {
            return $this->firstName;
        }        
        public function getLastName() {
            return $this->lastName;
        }        
        public function getAge() {
            return $this->$age;
        }
        public function setFirstName($firstName){
            $this->firstName = $firstName;
        }
        public function setLastName($lastName){
            $this->lastName = $lastName;
        }
        public function setAge($age){
            $this->age = $age;
        }
    }
    $person = new Person ();
    $person->setFirstName(readline());
    $person->setLastName(readline());
    $person->setAge(intval(readline()));
    
    echo "firstName: {$person->getFirstName()}" . PHP_EOL;
    echo "lastName: {$person->getLastName()}" . PHP_EOL;
    echo "age: {$person->getAge()}" . PHP_EOL;
?>