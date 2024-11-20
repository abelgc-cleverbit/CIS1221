# FILE: grammar.py
# This file demonstrates a simple parser based on the following grammar:
# add = mul | mul "+" mul
#       | mul "-" mul
#
# mul = term | term "*" term
#       | term "/" term
#
# term = 0..9  (single digits only!!!)
#
# To run this example, save this file as 'grammar.py' and run it using:
# python grammar.py
# You can modify the 'expression' variable to test different inputs.



class Parser:
    def __init__(self, expression):
        # Initialize the parser with the given expression
        # Remove spaces and set the initial index to 0
        self.tokens = expression.replace(' ', '')
        self.index = 0

    def parse(self):
        # Start parsing the expression by evaluating addition/subtraction
        return self.add()

    def add(self):
        # Evaluate addition and subtraction
        result = self.mul()
        while self.current_token() in ('+', '-'):
            if self.current_token() == '+':
                self.consume()
                result += self.mul()
            elif self.current_token() == '-':
                self.consume()
                result -= self.mul()
        return result

    def mul(self):
        # Evaluate multiplication and division
        result = self.term()
        while self.current_token() in ('*', '/'):
            if self.current_token() == '*':
                self.consume()
                result *= self.term()
            elif self.current_token() == '/':
                self.consume()
                result /= self.term()
        return result

    def term(self):
        # Return the current term (a single digit)
        # would you modify this to allow for multiple digits? 
        result = int(self.current_token())
        self.consume()
        return result

    def current_token(self):
        # Return the current token if within bounds, else None
        if self.index < len(self.tokens):
            return self.tokens[self.index]
        return None

    def consume(self):
        # Move to the next token
        self.index += 1

# very basic validation
def is_valid_expression(expression):
    """
    Checks if the given expression is valid.

    An expression is considered valid if it contains only digits (0-9), 
    arithmetic operators (+, -, *, /), and spaces.

    Args:
        expression (str): The expression to validate.

    Returns:
        bool: True if the expression is valid, False otherwise.
    """
    valid_chars = set("0123456789+-*/ ")
    return all(char in valid_chars for char in expression)


# Example usage:
expression = "3 + 5 * 2 - 4 / 2"
parser = Parser(expression)
result = parser.parse()
print(f"The result of '{expression}' is {result}")

# Interactive prompt for user input
while True:
    user_expression = input("Enter an expression (or 'quit' to exit): ")
    if user_expression.lower() == 'quit':
        break
    if is_valid_expression(user_expression):
        parser = Parser(user_expression)
        try:
            result = parser.parse()
            print(f"The result of '{user_expression}' is {result}")
        except Exception as e:
            print(f"Error parsing expression: {e}")
    else:
        print("Invalid expression. Please use only digits, '+', '-', '*', '/', and spaces.")