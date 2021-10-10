<?php

$Log = htmlspecialchars($_GET["Log"]);

$parameters = array(
    "chat_id" => 'REPLACE WITH YOUR CHAT ID',
    "text" => $Log
);
    
send("sendMessage", $parameters);
    
    function send($method, $parameters){
        $bot_token = "REPLACE WITH YOUR BOT TOKEN";
        $url = "https://api.telegram.org/bot$bot_token/$method";
        
        if(!$curl = curl_init()){
            exit();
        }
        
    curl_setopt($curl, CURLOPT_POST, true);
    curl_setopt($curl, CURLOPT_POSTFIELDS, $parameters);
    curl_setopt($curl, CURLOPT_URL, $url);
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
    $output = curl_exec($curl);
    return $output;
    }
    
?>