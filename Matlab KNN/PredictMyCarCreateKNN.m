clc
% This script assumes these tables are defined:
    %In100000
    %Out100000
x100000 = In100000{:,:};
t100000 = Out100000{:,:};

trainFcn = 'traingd';  % Gradient Descent
%trainFcn = 'traingdx'; % Variable Learning Rate Gradient Descent

% Create a Fitting Network
hiddenLayerSize = [40,40];

net = feedforwardnet(hiddenLayerSize,trainFcn);
net.trainParam.epochs=20000;

% Setup Division of Data for Training, Validation, Testing
net.divideParam.trainRatio = 80/100;
net.divideParam.valRatio = 15/100;
net.divideParam.testRatio = 5/100;

% Train the Network with GPU
count = gpuDeviceCount;
gpu1 = gpuDevice(1);
[net,tr] = train(net,x100000',t100000','useGPU','yes');

% Test the Network
y100000 = net(x100000');
e100000 = gsubtract(t100000',y100000);
performance100000 = perform(net,t100000',y100000);

% View the Network
view(net)
figure, plotperform(tr)


x25000 = In25000{:,:};
t25000 = Out25000{:,:};
y25000 = net(x25000');
e25000 = gsubtract(t25000',y25000);
performance25000 = perform(net,t25000',y25000);

genFunction(net,'Auswertung//PredictMyCarKNNFunctionGradientDescent');
writematrix(y25000','Auswertung//y25000csv.csv','Delimiter',';','DateLocale','de_DE')
save('Auswertung//ResultWB.mat')
%{
genFunction(net,'PredictMyCarKNNFunctionGradientDescent');
genFunction(net,'PredictMyCarKNNFunctionVariable');
x25000 = In25000{:,:};
t25000 = Out25000{:,:};
y25000 = net(x25000');
e25000 = gsubtract(t25000',y25000);
performance25000 = perform(net,t25000',y25000);

Excel -> CSV exportieren
writematrix(y25000','Auswertung//y25000csv.csv','Delimiter',';','DateLocale','de_DE')
Problem Punkt zu Komma:
Excel -> CSC importieren -> über Daten -> aus Text/CSV->Daten Transformieren -> Quelle: geänderter Typ Entfernen -> alles markieren -> Transformieren -> Analysieren -> JSON -> OK 

y2500_1=y2500(1:0)
sum(y2500_1)
y2500_1max = Max(y2500_1,0);
sum(y2500_1max)


y0=y25000(1,:);y0m=max(0,y0);y0_sum=sum(y0m)
y1=y25000(2,:);y1m=max(0,y1);y1_sum=sum(y1m)
y2=y25000(3,:);y2m=max(0,y2);y2_sum=sum(y2m)
y3=y25000(4,:);y3m=max(0,y3);y3_sum=sum(y3m)
y4=y25000(5,:);y4m=max(0,y4);y4_sum=sum(y4m)
y5=y25000(6,:);y5m=max(0,y5);y5_sum=sum(y5m)
y6=y25000(7,:);y6m=max(0,y6);y6_sum=sum(y6m)
y7=y25000(8,:);y7m=max(0,y7);y7_sum=sum(y7m)
y8=y25000(9,:);y8m=max(0,y8);y8_sum=sum(y8m)

%}


