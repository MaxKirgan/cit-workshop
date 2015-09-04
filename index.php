<?php
//Populate array with animals
$animals=array(
    'Monkey',
    //Add element here
    'Panda'
    );
//Select a random element(animal) from array
$result=array_rand ($animals,1 );
//Return result to screen
print 'Random animal from array: '.$animals[$result];
?>