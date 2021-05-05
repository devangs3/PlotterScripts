clc
% read script file    %%%%%%%%   
fid = fopen('scpiScript.txt');
% read each line of a file and store as array
x =  convertCharsToStrings(fgets(fid));
% read till end of file 
commands=[];
while ~feof(fid)
    commands = [commands; x]; 
    x =  convertCharsToStrings(fgets(fid));                      
end
fclose(fid);
%%%%%%%%%%%%%%%%%%%%%

% Transmit commands to the instrument 
% commands = ["*RST" "*CLS" ];

% Create TCP/IP object 't'. Specify server machine and port number. 
t = tcpclient('10.58.41.136', 5025);

for i=1:length(commands)
    write(t, commands(i)); 
    disp("executing:  " + commands(i))
    % pause(1) ;
    
    % wait for response 
%     while(t.NumBytesAvailable == 0)
%             disp("waiting...");
%             pause(1);
%     end
%     
%     % Receive lines of data from server 
%     while (t.NumBytesAvailable)
%         DataReceived = read(t);
%         disp("received "+ str(t.NumBytesAvailable )+ " bytes: " + DataReceived)
%     end 
end

% Disconnect and clean up the server connection. 
clear t 