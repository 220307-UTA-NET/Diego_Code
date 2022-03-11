#!usr/bin/bash
touch Date.txt

#timestamp=$(date +"%Y-%m-%d:%T")
date=$(date +"%Y-%m-%d")
time=$(date +"%T")

#echo "Script ran at:" $timestamp >> Date.txt
if [ -e ${date}.txt ]; then
	echo "Script ran at ${time}" >> ${date}.txt
else
	echo "Starting file for ${date} at ${time}" >> ${date}.txt
fi
