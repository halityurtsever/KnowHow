### Insertion sort algorithm

Compares xth element of an array with previous indexes until find a smaller one
Then it shifts biggers to right until the smaller one then insert the xth element to new place in the array

Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4

Pass 1             -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
                      ^
                      insert 3 before 7, shift other elements to right

Pass 2             -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
                              ^
                              9 remains because it is bigger than 7

Pass 3             -> 3 - 5 - 7 - 9 - 2 - 8 - 6 - 1 - 4
                          ^
                          insert 5 before 7, shift other elements to right

Pass 4             -> 2 - 3 - 5 - 7 - 9 - 8 - 6 - 1 - 4
                      ^
                      insert 2 before 3, shift other elements to right
and goes on...

Worst case performance: O(n2) comparisons, swaps
Best case performance: O(n) comparisons, O(1) swaps
Average performance: O(n2) comparisons, swaps
Worst case space complexity: O(n) total, O(1) auxiliary