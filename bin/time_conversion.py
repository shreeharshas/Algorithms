#!/bin/python

import sys


time = raw_input().strip()
split_time_arr = time.split(':', 3)

# border conditions are 12 AM and 12 PM - the usual logic is reversed if 12 is encountered
twelve_or_not = True if int(split_time_arr[0]) == 12 else False

if "AM" == split_time_arr[2][-2:]:
    if twelve_or_not is False:  #normal flow
        print time[:-2]         # just print the time without the meridiem because it is within the limits
    else:                       # if 12AM, it is 00:mn:pq  - so print 00 as the hour
        print "00:" + split_time_arr[1] + ":" + split_time_arr[2][:-2]
else:
    if twelve_or_not is False:  # normal flow
        temp = (int(split_time_arr[0]) + 12) % 24   # main logic to convert into military format
        if len(str(temp)) < 2:  # sub logic to ensure that the prefix 0 is still retained during post int conversion
            first = "0" + str(temp)
        else:
            first = str(temp)
        
        if len(split_time_arr[1]) < 2:
            second = "0" + split_time_arr[1]# sub logic to ensure that the prefix 0 is still retained during post int conversion
        else:
            second = split_time_arr[1]
        
        if len(split_time_arr[2][:-2]) < 2:
            third = "0" + split_time_arr[2][:-2]# sub logic again
        else:
            third = split_time_arr[2][:-2]
        print first + ":" + second + ":" + third    # concat and print the time in hh:mm:ss format
        
    else:               # if 12PM, do nothing but removing the meridiem
        print time[:-2] 
        
