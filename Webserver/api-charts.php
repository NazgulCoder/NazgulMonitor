<?php

	$Info = htmlspecialchars($_GET["Info"]);
	/*  $Info = str_replace(";", PHP_EOL, $Info);   //replaces ; with new line break
	$Log = htmlspecialchars($_GET["Log"]);      */
	
	if (empty($Info)) { }
    else{
	
	$myfile = fopen("charts.csv", "a") or die("Unable to open file!");
    fwrite($myfile, $Info);
    fwrite($myfile, "\n");
    fclose($myfile);
    }

?>