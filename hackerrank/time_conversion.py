# File           : diagonalDifference.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/time-conversion
''' Description    : 
Given a time in AM/PM format, convert it to military (2424-hour) time.

Note: Midnight is 12:00:00AM12:00:00AM on a 1212-hour clock and 00:00:0000:00:00 on a 2424-hour clock. Noon is 12:00:00PM12:00:00PM on a 1212-hour clock and 12:00:00PM12:00:00PM on a 2424-hour clock.

Input Format

A single string containing a time in 1212-hour clock format (i.e.: hh:mm:ssAMhh:mm:ssAM or hh:mm:ssPMhh:mm:ssPM), where 01≤hh≤1201≤hh≤12.

Output Format

Convert and print the given time in 2424-hour format, where 00≤hh≤2300≤hh≤23.

Sample Input

07:05:45PM
Sample Output

19:05:45
'''
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
