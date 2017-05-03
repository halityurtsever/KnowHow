### Selection sort algorithm

Finds the min number in the array and swaps it with the number in the first index
Then by skipping first index, again find the min number in the array and swaps it with the second index
and iterates recursively by skipping indexes incremently

Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4

Pass 1             -> 1 - 3 - 9 - 5 - 2 - 8 - 6 - 7 - 4
                      ^---------------------------^
                      swap 7 and 1

Pass 2             -> 1 - 2 - 9 - 5 - 3 - 8 - 6 - 7 - 4
                          ^-----------^
                          skip { 1 }, swap 3 and 2

Pass 3             -> 1 - 2 - 3 - 5 - 9 - 8 - 6 - 7 - 4
                              ^-------^
                              skip { 1 - 2 }, swap 3 and 9
                              
Pass 4             -> 1 - 2 - 3 - 4 - 9 - 8 - 6 - 7 - 5
                                  ^-------------------^
                                  skip { 1 - 2 - 3 }, swap 4 and 5

and goes on...

Worst case performance: O(n2)
Best case performance: O(n)
Average performance: O(n2)
Worst case space complexity: O(n) total, O(1) auxiliary