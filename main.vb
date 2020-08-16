Imports System
				
Public Module VBModule
	Public Sub Main()
        Dim webClient As New System.Net.WebClient
        
        '
        '   Get your SMSLink / SMS Gateway Connection ID and Password from 
        '     https://www.smslink.ro/get-api-key/
        '
        
        '		HTTPS API Endpoint:  https://secure.smslink.ro/sms/gateway/communicate/index.php
	'		HTTP API Endpoint:   http://www.smslink.ro/sms/gateway/communicate/index.php

        Dim result As String = webClient.DownloadString("https://secure.smslink.ro/sms/gateway/communicate/index.php?connection_id=... My Connection ID ...&password=... My Connection Password ...&to=07xyzzzzzz&message=test")
        Console.WriteLine(result)
    End Sub
End Module
