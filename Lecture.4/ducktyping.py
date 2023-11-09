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
    # def fly(self):
    #     print('Flap')



class Human:
    def quack(self):
        print('Trying to Quack like a duck')
    def fly(self):
        print('Spreading my arm to flap like a duck')   

def fly_quack(thing):
    thing.quack()
    thing.fly()