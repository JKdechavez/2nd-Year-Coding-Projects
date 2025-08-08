"""
Purpose: Create an application to count the word frequencies in a given text and provide
functionalities to search and retrieve word frequency information using Dictionary ADT, Hash
Tables, and Binary Search Trees.
Programmer: Karl Ivan Mariscotes, Naomi Odejar
Date Created: Nov 1, 2023
Date Modified: Nov 3, 2023
Language: Python
IDE: PyCharm
"""

class Node:
    def __init__(self, key, value):
        self.key = key
        self.value = value
        self.next = None

class HashTable:
    def __init__(self, size):
        self.table = [None] * size
        self.N = size

    def hash_function(self, key):
        sum = 0
        for char in key:
            sum += ord(char)
        return sum % self.N

    def insert(self, key, value):
        index = self.hash_function(key)
        node = Node(key, value)
        node.next = self.table[index]
        self.table[index] = node

    def get(self, key):
        values = []
        index = self.hash_function(key)
        if self.table[index] is not None:
            ptr = self.table[index]
            while ptr is not None:
                if ptr.key == key:
                    values.append(ptr.value)
                ptr = ptr.next
            if len(values) > 0:
                return values
            return None

    def delete(self, key):
        index = self.hash_function(key)
        prev = None
        current = self.table[index]
        while current is not None:
            if current.key == key:
                if prev is None:
                    self.table[index] = current.next
                else:
                    prev.next = current.next
                delptr = current
                current = current.next
                del delptr
            else:
                prev = current
                current = current.next

class Node:
    def __init__(self, key, value):
        self.key = key
        self.value = value
        self.left = None
        self.right = None

class BinarySearchTree:
    def __init__(self):
        self.root = None

    def search(self, item):
        return self._search(self.root, item)

    def _search(self, node, item):
        if node is None or node.key == item:
            return node
        if item < node.key:
            return self._search(node.left, item)
        return self._search(node.right, item)

    def insert(self, key, value):
        self.root = self._insert(self.root, key, value)

    def _insert(self, node, key, value):
        if node is None:
            return Node(key, value)
        if key == node.key:
            node.value = value
        elif key < node.key:
            node.left = self._insert(node.left, key, value)
        else:
            node.right = self._insert(node.right, key, value)
        return node

    def in_order_traversal(self):
        result = []
        self._in_order_traversal(self.root, result)
        return result

    def _in_order_traversal(self, node, result):
        if node:
            self._in_order_traversal(node.left, result)
            result.append((node.key, node.value))
            self._in_order_traversal(node.right, result)

def tokenize(text):
    words = text.lower().split()
    words = [word.strip('.,?!()[]{}:;"\'') for word in words]
    return words

def create_hash_table(words):
    hash_table = HashTable(len(words))
    for word in words:
        if hash_table.get(word):
            frequency = hash_table.get(word)[0]
            hash_table.delete(word)
            hash_table.insert(word, frequency + 1)
        else:
            hash_table.insert(word, 1)
    return hash_table

def create_binary_search_tree(words):
    bst = BinarySearchTree()
    for word in words:
        node = bst.search(word)
        if node is None:
            bst.insert(word, 1)
        else:
            node.value += 1
    return bst


text = "Bachelor of Science in Computer Engineering, Bachelor of Science in Information Technology"
words = tokenize(text)
print(f"Word: {text}")

hash_table = create_hash_table(words)

bst = create_binary_search_tree(words)

word_to_search = "in"
frequency = hash_table.get(word_to_search)
if frequency:
    print(f"The word '{word_to_search}' appears {frequency[0]} times in the text (using Hash Table).")
else:
    print(f"The word '{word_to_search}' was not found in the text (using Hash Table).")

node = bst.search(word_to_search)
if node is not None:
    print(f"The word '{word_to_search}' appears {node.value} times in the text (using Binary Search Tree).")
else:
    print(f"The word '{word_to_search}' was not found in the text (using Binary Search Tree).")

in_order_result = bst.in_order_traversal()
print("Words and their frequencies in alphabetical order:")
for key, value in in_order_result:
    print(f"{key} -> {value}")


