<?php
$myfile = fopen("logs.txt", "w") or die("Unable to open file!");
fwrite($myfile, "");
fclose($myfile);


header('Location: index.html', true, 302);
exit();
?>