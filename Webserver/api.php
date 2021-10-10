<?php

	$Info = htmlspecialchars($_GET["Info"]);
	$Info = str_replace(";", PHP_EOL, $Info);   //replaces ; with new line break
	$Log = htmlspecialchars($_GET["Log"]);
	
	if (empty($Info)) { }
    else{
	
	$myfile = fopen("info.txt", "w") or die("Unable to open file!");
    fwrite($myfile, $Info);
    fclose($myfile);
    }
    
    if (empty($Log)) { }
    else{
    
    $myfile = fopen("logs.txt", "a") or die("Unable to open file!");
    fwrite($myfile, $Log);
    fwrite($myfile, "\n");
    fclose($myfile);
    
    
    $myfile = fopen("logsbackup.txt", "a") or die("Unable to open file!");
    fwrite($myfile, $Log);
    fwrite($myfile, "\n");
    fclose($myfile);
    
    }

?>