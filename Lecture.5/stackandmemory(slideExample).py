# use py to interactively run this file
# use exec(open("stackandmemory(slideExample).py").read()) to dynamically load this file
# repeat the above multiple times, compare the outputs

# This script uses the trace module to trace the execution of the main function. 
# The trace=True argument tells the Trace object to print each line of code as it is executed, 
# which will give you a detailed view of the stack and the activation registry during the execution.


import sys
import trace

# Define a Circle class with attributes for x, y coordinates and radius
class Circle:
    def __init__(self, x, y, radius):
        # Initialize the Circle object with x, y coordinates and radius
        self._x = x
        self._y = y
        self._radius = radius
    
    # Getter method for x coordinate
    def get_x(self):
        return self._x
        
    # Getter method for y coordinate
    def get_y(self):
        return self._y

    # Getter method for radius
    def get_radius(self):
        return self._radius

# Function to calculate the area of a circle
def area(c):
    # Use the radius of the circle to calculate the area
    return 3.14 * c.get_radius()**2

# Main function to demonstrate the Circle class and area calculation
def main():
    # Initialize x, y coordinates and radius
    x = 0
    y = 0
    radius = 2
    
    # Create a Circle object with the given x, y coordinates and radius
    circle = Circle(x, y, radius)
    
    # Calculate the area of the circle
    result = area(circle)
    
    # Print the result
    print(f"Area of the circle: {result}")

# Create a Trace object, telling it what to ignore, and whether to do tracing or line-counting or both.
tracer = trace.Trace(
    ignoredirs=[sys.prefix, sys.exec_prefix],
    trace=True,
    count=False
)

# Run the main function under the control of the Trace object.
tracer.run('main()')