state = [
    [206, 243, 61, 34],
    [171, 11, 93, 31],
    [16, 200, 91, 108],
    [150, 3, 194, 51],
]

round_key = [
    [173, 129, 68, 82],
    [223, 100, 38, 109],
    [32, 189, 53, 8],
    [253, 48, 187, 78],
]
def xor_matrices(matrix1, matrix2):
    result = []
    for row1, row2 in zip(matrix1, matrix2):
        xor_row = [a ^ b for a, b in zip(row1, row2)]
        result.append(xor_row)
    return result

def matrix2bytes(matrix):
    """ Converts a 4x4 matrix into a 16-byte array.  """
    return bytes(sum(matrix, []))

def add_round_key(s, k):
    result = []
    row_result = []
    for row1, row2 in zip(s, k):
        for i,o in zip (row1, row2):
            row_result.append(i^0)
        result.append(row_result)
    return result
print(matrix2bytes(xor_matrices(state, round_key)))

