
# use py to interactively run this file
# use exec(open("gcd.py").read()) to dynamically load defintions in this file or directly run 'py -i .\gcd.py'
# run by  executing: 
#  >>> gcd_it(10,20)
#  >>> gcd_rec(10,20)
#  >>> gcd_fun(10,20)


# iterative ugly
def gcd_it_ugly(a,b):
    while  a != 0 and b != 0:
        if a > b:
            a = a - b
        else:
            b = b - a
    
    if a == 0:
        return b
    else:
        return a
    


# iterative accelerated algorithm
def gcd_it(a,b):
    while b:
        a,b = b, a%b # pattern matching expression
    return a

# recursive approach
def gcd_rec(a,b):
    return a if not b else gcd_rec(b, a%b)

# functional approach 
gcd_fun = lambda a,b : a if not b else gcd_fun(b, a%b)


