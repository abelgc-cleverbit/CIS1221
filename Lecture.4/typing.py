
# use py to interactively run this file
# use exec(open("typing.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'
# run by  executing: 
#  type(xString)
#  type(yInt)
# compare according to the ramdonly generated values
# try print(xString + 2) in each case


import random

def RamdonBool():
    # comment the below to force behavior
    b = bool(random.getrandbits(1))
    print("RandomBool generated: " + str(b))
    return b

    # uncomment the below to force behavior
    # return False 

if RamdonBool():
    xString = "9"
    yInt = 5
else:
    xString = 5
    yInt = "7"

