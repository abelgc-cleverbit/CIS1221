import random
import time


start_time = time.time()

# Generate a list of 1 million integers between 1 and 100
my_list = [random.randint(1, 1000000) for i in range(1000000)]

end_time = time.time()

total_time = end_time - start_time

print("Time taken to generate the list: ", total_time)

my_list.sort()

end_time = time.time()

total_time = end_time - start_time

print("Time taken to sort the list: ", total_time)

