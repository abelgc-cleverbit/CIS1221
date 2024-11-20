# FILE: grammar_tree.py
# This file demonstrates a simple parser based on the following grammar:
# add = mul | mul "+" mul
#       | mul "-" mul
#
# mul = term | term "*" term
#       | term "/" term
#
# term = 0..9
#
# To run this example, save this file as 'grammar_tree.py' and run it using:
# python grammar_tree.py
# You can modify the 'expression' variable to test different inputs.

class Node:
    """Base class for all nodes in the expression tree."""
    def evaluate(self):
        raise NotImplementedError("Must be implemented by subclasses")

    def __str__(self):
        raise NotImplementedError("Must be implemented by subclasses")

class Number(Node):
    """Represents a number in the expression tree."""
    def __init__(self, value):
        self.value = value

    def evaluate(self):
        return self.value

    def __str__(self):
        return str(self.value)

class BinaryOperation(Node):
    """Base class for binary operations in the expression tree."""
    def __init__(self, left, right):
        self.left = left
        self.right = right

class Add(BinaryOperation):
    """Represents addition in the expression tree."""
    def evaluate(self):
        return self.left.evaluate() + self.right.evaluate()

    def __str__(self):
        return f"({self.left} + {self.right})"

class Subtract(BinaryOperation):
    """Represents subtraction in the expression tree."""
    def evaluate(self):
        return self.left.evaluate() - self.right.evaluate()

    def __str__(self):
        return f"({self.left} - {self.right})"

class Multiply(BinaryOperation):
    """Represents multiplication in the expression tree."""
    def evaluate(self):
        return self.left.evaluate() * self.right.evaluate()

    def __str__(self):
        return f"({self.left} * {self.right})"

class Divide(BinaryOperation):
    """Represents division in the expression tree."""
    def evaluate(self):
        return self.left.evaluate() / self.right.evaluate()

    def __str__(self):
        return f"({self.left} / {self.right})"

class Parser:
    """Parses an expression and builds an expression tree."""
    def __init__(self, expression):
        self.tokens = expression.replace(' ', '')
        self.index = 0

    def parse(self):
        return self.add()

    def add(self):
        node = self.mul()
        while self.current_token() in ('+', '-'):
            if self.current_token() == '+':
                self.consume()
                node = Add(node, self.mul())
            elif self.current_token() == '-':
                self.consume()
                node = Subtract(node, self.mul())
        return node

    def mul(self):
        node = self.term()
        while self.current_token() in ('*', '/'):
            if self.current_token() == '*':
                self.consume()
                node = Multiply(node, self.term())
            elif self.current_token() == '/':
                self.consume()
                node = Divide(node, self.term())
        return node

    def term(self):
        """Parses a term (a number)."""
        start = self.index
        while self.current_token() and self.current_token().isdigit():
            self.consume()
        return Number(int(self.tokens[start:self.index]))

    def current_token(self):
        """Returns the current token if within bounds, else None."""
        if self.index < len(self.tokens):
            return self.tokens[self.index]
        return None

    def consume(self):
        """Moves to the next token."""
        self.index += 1

def is_valid_expression(expression):
    """Checks if the given expression is valid."""
    valid_chars = set("0123456789+-*/ ")
    return all(char in valid_chars for char in expression)

# COPILOT GENERATED: 
#basic recursive tree printing
def print_tree(node, prefix="", is_left=True, is_root=True):
    """Recursively prints the expression tree with lines ensuring all siblings are at the same level."""
    if is_root:
        print(str(node))
    else:
        print(prefix + ("|-- " if is_left else "\\-- ") + str(node))
    
    if isinstance(node, BinaryOperation):
        new_prefix = prefix + ("|   " if is_left else "    ")
        print_tree(node.left, new_prefix, True, False)
        print_tree(node.right, new_prefix, False, False)

# Convert the expression tree to a Python expression string
def tree_to_expression(node):
    """Converts the expression tree to a Python expression string."""
    if isinstance(node, Number):
        return str(node.value)
    elif isinstance(node, Add):
        return f"Add({tree_to_expression(node.left)}, {tree_to_expression(node.right)})"
    elif isinstance(node, Subtract):
        return f"Subtract({tree_to_expression(node.left)}, {tree_to_expression(node.right)})"
    elif isinstance(node, Multiply):
        return f"Multiply({tree_to_expression(node.left)}, {tree_to_expression(node.right)})"
    elif isinstance(node, Divide):
        return f"Divide({tree_to_expression(node.left)}, {tree_to_expression(node.right)})"

# Example usage:
expression = "3 + 5 * 2 - 4 / 2"

while True:
    if expression.lower() == 'quit':
        break
    if is_valid_expression(expression):
        parser = Parser(expression)
        try:
            tree = parser.parse()

            print(f"The expression tree for '{expression}' is: {tree}")
            print(f"The Python expression that builds the tree is: {tree_to_expression(tree)}")
            print()
            print("Expression tree:")
            print_tree(tree)
            print()
            print(f"The result of '{expression}' is {tree.evaluate()}")

        except Exception as e:
            print(f"Error parsing expression: {e}")
    else:
        print("Invalid expression. Please use only digits, '+', '-', '*', '/', and spaces.")
    
    expression = input("Enter an expression (or 'quit' to exit): ")
