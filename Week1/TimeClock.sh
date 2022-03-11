#!usr/bin/bash

echo "Runnng timeclock.sh..."

EmployeeNames=()

while true; do
	
	read -p $'Enter Name: \n' input
	timestamp=$(date +"%Y-%m-%d:%T")

	echo $input "Clocked in at:" $timestamp
	if [[ ${input^^} == "STOP" ]]; then
		break
	elif [[ -z $input ]]; then
		echo "empty input found, please try again"
	fi
	
	if [[ -n $input ]]; then
		if [[ ${#input} > 5 ]]; then
			echo "Input longer than 5 characters"
		fi
	fi
	
	EmployeeNames+=("$input:$timestamp")
	sleep 1
done


for name in ${EmployeeNames[@]}; do
	echo $name >> ./ClockInOut.txt
	
done

echo "Program has Ended..."
