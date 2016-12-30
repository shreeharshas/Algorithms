# File           : fizzbuzz.py
# Author         : Shree Harsha Sridharamurthy
# Author email   : sridhash@iu.edu
# Disclaimer     : This program is solely created by Shree Harsha for academic purposes.
#                 For use by concerned personnel only. Not to be copied in full or in part.
# Program        : To accept a number n and print all the numbers from 1 to n as fizz if divisible by 2
#                 or buzz if divisible by 3 or fizzbuzz if divisible by both else just the number itself

import sys
try:
    arg_num = sys.argv[1]
    try:
        n = int(float(arg_num))

        for i in range(1, (n+1)):
            if i % 2 == 0:
                if i % 3 == 0:          #already divisible by 2 hence check for 3 here which checks for 6
                    print "fizzbuzz"
                else:
                    print "fizz"        #only divisible by 2
            elif i % 3 == 0:            #only divisible by 2
                print "buzz"
            else:                       #divisible by neither 2 nor 3
                print i
    except ValueError:
        print "\nUsage:\tpython fizzbuzz.py <num>\n\tnum: The number to be checked"
except IndexError:
    print "\nUsage:\tpython fizzbuzz.py <num>\n\tnum: The number to be checked"
