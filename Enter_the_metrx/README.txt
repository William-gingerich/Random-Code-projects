███████╗███╗   ██╗████████╗███████╗██████╗     ████████╗██╗  ██╗███████╗    ███╗   ███╗ █████╗ ████████╗██████╗ ██╗██╗  ██╗
██╔════╝████╗  ██║╚══██╔══╝██╔════╝██╔══██╗    ╚══██╔══╝██║  ██║██╔════╝    ████╗ ████║██╔══██╗╚══██╔══╝██╔══██╗██║╚██╗██╔╝
█████╗  ██╔██╗ ██║   ██║   █████╗  ██████╔╝       ██║   ███████║█████╗      ██╔████╔██║███████║   ██║   ██████╔╝██║ ╚███╔╝ 
██╔══╝  ██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗       ██║   ██╔══██║██╔══╝      ██║╚██╔╝██║██╔══██║   ██║   ██╔══██╗██║ ██╔██╗ 
███████╗██║ ╚████║   ██║   ███████╗██║  ██║       ██║   ██║  ██║███████╗    ██║ ╚═╝ ██║██║  ██║   ██║   ██║  ██║██║██╔╝ ██╗
╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝       ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝
  
DESCRIPTION
---------------------------------------------------------------------------------------------------------------------------
In order to crack the Matrix code and return to the one true reality, you must write a program to calculate the sum of the
diagonals of a series of square character matrices.


PERMITTED NAMESPACES
---------------------------------------------------------------------------------------------------------------------------
System
System.IO


INPUT SPECIFICATION
---------------------------------------------------------------------------------------------------------------------------
The file "input.txt" contains the data for several character matrices.  The first line indicates the number of matrices
in the file.  The data from each matrix is on a single line, such that each character from the line will fill an NxN matrix 
starting at the upper-left corner.

For example, the data k&%8sk)!0 will fill a 3x3 matrix as...

k&%
8sk
)!0                                                                                                                        


OUTPUT SPECIFICATION
----------------------------------------------------------------------------------------------------------------------------
Your program should match "sample-output.txt" exactly.  Note that characters are summed according to their ASCII codes.