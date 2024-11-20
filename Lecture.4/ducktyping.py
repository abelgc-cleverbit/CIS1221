# use py to interactively run this file
# use exec(open("ducktyping.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'
# run by  executing: 
# du = Duck()
# fly_quack(du)
# h = Human()
# fly_quack(h)
# try removing an attribute and see what happens


class Duck:
    def quack(self):
        print('Quack')
    def fly(self):
        print('Flap')

class RobotDuck:
    def quack(self):
        print('Quacking like a robot duck')

class Human:
    def quack(self):
        print('Trying to Quack like a duck')
    def fly(self):
        print('Spreading my arm to flap like a duck')   

def fly_quack(thing):
    # In Python, we don't need an interface. We rely on duck typing.
    # If it quacks like a duck and flies like a duck, it must be a duck.
    thing.quack()
    thing.fly()

# Advantages of dynamic typing in Python:
# 1. Flexibility: We can pass any object to fly_quack as long as it has quack and fly methods.
# 2. Less boilerplate: No need to define interfaces or implement them explicitly.
# 3. Easier to write and read: Less code to achieve the same functionality.

# Disadvantages of dynamic typing in Python:
# 1. Runtime errors: Errors related to missing methods or attributes are only caught at runtime.
# 2. Less tooling support: IDEs and tools may have a harder time providing accurate autocompletion and type checking.
# 3. Potential for bugs: It's easier to introduce bugs due to the lack of compile-time type checking.

# Example usage:
du = Duck()
fly_quack(du)
h = Human()
fly_quack(h)

# Try removing an attribute (e.g., comment out the fly method in Duck) and see what happens.
# Python will raise an AttributeError at runtime if the method is missing.