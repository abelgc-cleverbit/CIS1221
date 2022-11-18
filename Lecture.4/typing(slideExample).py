# use py to interactively run this file
# use exec(open("typing(slideExample).py").read()) to dynamically load this file
# repeat the above multiple times, compare the outputs


import random

def RamdonBool():
    return bool(random.getrandbits(1))
    
if RamdonBool():
    x = "9"
else:
    x = 9

print(x+2) # a type violation 'may' occur if the execution path assigns x the type string

y = "string"
print(y+2) # a type violation 'will' occur