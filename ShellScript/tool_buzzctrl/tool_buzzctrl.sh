# buzzctrl ( -poweron | -poweroff | -shutdown | -reboot | -warning | -error 

while true
do
echo ====================================================================
echo buzzctrl -exit = 0
echo buzzctrl -poweron = 1
echo buzzctrl -poweroff = 2
echo buzzctrl -shutdown = 3
echo buzzctrl -reboot = 4
echo buzzctrl -warning = 5
echo buzzctrl -error = 6
echo ====================================================================
printf 'input option: '  #printf = 輸入時直接在同一行, 不會輸入的數值跑到下一行

read -r option # -r 是防止特殊處理?

# echo 'your option was:' $option

if [ $option == "0" ];then #if 的 [] 空格要正確...不然會錯誤
    echo -e "\e[1;32mBye Bye~\e[0m"
    break
elif [ $option == "1" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -poweron \e[0m"; buzzctrl -poweron
elif [ $option == "2" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -poweroff \e[0m"; buzzctrl -poweroff
elif [ $option == "3" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -shutdown \e[0m"; buzzctrl -shutdown
elif [ $option == "4" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -reboot \e[0m"; buzzctrl -reboot
elif [ $option == "5" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -warning \e[0m"; buzzctrl -warning
elif [ $option == "6" ];then
    echo -e "\e[1;31mRun_CMD: buzzctrl -error \e[0m"; buzzctrl -error
else
    echo -e "\e[1;32mWrong Option Bye\e[0m"
fi

done