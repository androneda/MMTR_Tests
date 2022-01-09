<?php

if (isset($_POST["name"]) && isset($_POST["color"]) && isset($_POST["age"]) && isset($_POST["timeday"]) ) { 

	// Формируем массив для JSON ответа
    $result = array(
    	'name' => $_POST["name"],
    	'color' => $_POST["color"]
    	'age' => $_POST["age"]
    	'timeday' => $_POST["timeday"]
    ); 

    // Переводим массив в JSON
    echo json_encode($result); 
}

?>