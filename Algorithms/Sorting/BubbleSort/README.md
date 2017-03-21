### Bubble sort algorithm

Swaps [i] and [i + 1] if [i] smaller then [i + 1] until array ordered

Initial Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4

Pass 1           -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
                    ^---^
                    swap 7 and 3

Pass 2           -> 3 - 7 - 5 - 9 - 2 - 8 - 6 - 1 - 4
                            ^---^
                            swap 9 and 5

Pass 3           -> 3 - 7 - 5 - 2 - 9 - 8 - 6 - 1 - 4
                                ^---^
                                swap 9 and 2
and goes on...

Worst case performance: O(n2)

Best case performance: O(n)

Average performance: O(n2)

Worst case space complexity: O(1) auxiliary