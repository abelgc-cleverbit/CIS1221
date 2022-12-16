# use py to interactively run this file
# use exec(open("operators.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'

# whole division or decimal division
print(2 * 3 / 5)
print(2 * 3 // 5)

# exponentiation is right-associative
print(2 ** 2 ** 3)  
print((2 ** 2) ** 3) 

# translated to an "and" expression
print (4 > 3 > 1) # true
print (4 > 3 == 2) # false
print (4 > 2 == 2) # true
