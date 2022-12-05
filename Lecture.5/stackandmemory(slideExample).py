# use py to interactively run this file
# use exec(open("stackandmemory(slideExample).py").read()) to dynamically load this file
# repeat the above multiple times, compare the outputs



class Circle:
    def __init__(self, x, y, radius):
        self._x = x
        self._y = y
        self._radius = radius
    
    def get_x(self):
        return self._x
        
    def get_y(self):
        return self._y

    def get_radius(self):
        return self._radius

def area(c):
    return 3.14 * c.get_radius()**2

x = 0
y = 0
radius = 2
circle = Circle(x, y, radius)
result = area(circle)