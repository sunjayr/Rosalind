def count(sequence):
    answer = []
    counts = {}
    for letter in sequence:
        if letter in counts.keys():
            counts[letter] += 1
        else:
            counts[letter] = 1
    answer.append(str(counts['A']))
    answer.append(str(counts['C']))
    answer.append(str(counts['G']))
    answer.append(str(counts['T']))

    return ' '.join(answer)

print count("GCATGCGGATCCTCCTTCAGACCGCCTGTATAGTAGAGTAATTAGAATAACCATACCGAAATGATAGCCGTAAACCAGTGCGTCCATTTCAGCTTACTGGCTGCTCCGCGATGTTGGAGGGTTAGACAAATCATGCTGCCGCCGCAAACACAATGGGACAGCGCCGTGATTGGTATTTGCTACTACTCCCATACTCCGAAGAGCGGCGTGACAAAAAAACGTTACCGTAATTCCCGAGCCGTGAATCTGAAGACGCTTGCTGTATGGAGCTACACACTAGTAACTCATCAGCCTATAGGAGTACTTCCAGTGGCGTGGCTTACCACTCAGCTCGCTCATCCTACTGAGGCTTTCTTGTAAAGGGATGGGTTACTTGCGAGCCAAAGCGAACGATGATTGGCGGTGAACCATTGTACGTATTAAGATAGTACTTTGGGTACCTCCACTTCACAATTCACGGGACTCGGTTAGAGGTCCGGCTGAGGGTTACATAACCTGTTCTAGACTCCATGACTCAAGATTCGCGCCTTATGTGATCCGTGATAAAAGTAAGAAACCTGCCGACATGAAATGGATTTTGTGGGCACCTTTCTTCCTAGACTTCAGTGCTGTCTTTAAAGTTTCAGACAGCGTACCAATAGCGTTCATCAGTGTTATAATCGGTCCCTACGTACCTGTCGCATTGTTCCCGAAAAGCTGGTGTGAAAATATGTCCTTCGGTGAGACCGGGCCTGTATTTCCTCGGCTTAGTCGAATCGATTTTTCCCCCTCAGGGTCCCGGTAAGGTCCAGAGCTGAGCATGCTGTTGGACCTGACTCCGTGGGACGACCAATGTAAAATTTCAAACTTTGTTTCTCCTCCAAGTTGGGGTCTGAGACTCTAGAGGGCCGTATCCGTGGGACTGGTGTATAGCCCATTAAGGCGGAAGAGGGCAAGACGCCTACCCTACTGGATGTCCCAAGACCTCAACTTCGACGATTATATCGGAAGCGCC")