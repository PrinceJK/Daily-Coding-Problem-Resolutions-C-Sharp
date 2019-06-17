# Daily-Coding-Problem-3---Google
Here is the resolution to the third Coding Problem sent to me by www.dailycodingproblem.com.

I have to say, this was a tricky one, because...first of all i didn't know what was a binary tree, so the terms "node", "root"
scared me. And i had to do a little research about the topic, since i wasn't familiar with the concept of this data structure.

For those who also aren't familiar with this concept, here is a video that helped me a lot in the process of understanding and solving this problem : https://www.youtube.com/watch?v=ZNH0MuQ51m4

If you have any suggestions on how to improve this resolution, feel free to contact me.

Here is the Problem:
 
"
This problem was asked by Google.

Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.

For example, given the following Node class
```
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
```
        
The following test should pass:

node = Node('root', Node('left', Node('left.left')), Node('right'))
assert deserialize(serialize(node)).left.left.val == 'left.left'
"
