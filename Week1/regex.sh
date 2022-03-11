#!usr/bin/bash

test="Hello,World!"
reg="q$"

if [[ $test =~ $reg ]]; then
	echo "yes"
else
	echo "no"
fi
