# use py to interactively run this file
# use exec(open("parameters.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'

def f(i, a1, a2, a3, s):
    print("    f received value of i = " + str(i))
    i = 2
    print("    f current value of i = " + str(i))

    print("    f received value of a1 = " + str(a1))
    a1[1] = "f"
    print("    f current value of a1 = " + str(a1))

    print("    f received value of a2 = " + str(a2))
    a2 = ["f","f","f"]
    print("    f current value of a2 = " + str(a2))

    print("    f received value of a3 = " + str(a3))
    a3+= ["f"]
    print("    f current value of a3 = " + str(a3))

    print("    f received value of s = " + s)
    s+="mela"
    print("    f current value of s = " + s)

i = 1
print("before f value of i = " + str(i))

a1 = [1,1,1]
a2 = [2,2,2]
a3 = [3,3,3]
print("before f value of a1 = " + str(a1))
print("before f value of a1 = " + str(a2))
print("before f value of a1 = " + str(a3))

s = "_"
print("before f value of s = " + s)

print()
f(i, a1, a2, a3, s)
print()

print("after f value of i = " + str(i))
print("after f value of a1 = " + str(a1))
print("after f value of a2 = " + str(a2))
print("after f value of a3 = " + str(a3))
print("after f value of s = " + s)


