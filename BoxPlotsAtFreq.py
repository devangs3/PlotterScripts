# create box plots of all DUTs at a given frequency
# Use Tableau Box extracts
# for all impedance parameters
# List all DUTs considered
# Create table of number of points, mean, median, Q1 and Q3 below akin Spotfire
# create image for each impedance parameter
# color red for defect, green for good
# export as SVG

# ask user for an extract file
print("TI Box Plotter v1.0")
print("Pro tip: copy file name from the address bar of your window ;)")
name = raw_input("What is your file path with extension?: ")

# read the file with column hierarchy specifically in this order
# headerCombo,pinCombo, DUT name, run number
data = pd.read_excel(name, header=[0, 1, 2, 3, 4], sheetname="Bode")

# box plot for given DUT at selected frequency
boxplot = df.boxplot(column=header[3])

for pins in pinCombos:
    for param in parameters:
        for date in datesList:
            boxplot = df.boxplot(column=['Col1', 'Col2', 'Col3'])
