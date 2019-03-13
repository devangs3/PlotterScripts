# Create Nyquist plots for all DUTs at all frequencies
# Use Tableau Bode extracts
# List all DUTs considered
# color good as green, bad as red
# export as SVG

import pandas as pd  # data processing, CSV file I/O (e.g. pd.read_csv)
import matplotlib.pyplot as plt
import svgutils.transform as sg

# ask user for an extract file
print("TI Nyquist Plotter v1.0")
print("What is your file path with extension?")
name = input("Pro tip: copy file name from the address bar of your window: ")
# for test only
name = "C:/Users/Devang/Box Sync/DATA Folder Good_Bad DUT" \
       "/Data/MasterSummary/Master_Summary.xlsx"
#

# ask for pin combinations
print("What pin combination do you want to report?")
pinComboIn = input("Type required combinations with comma; e.g. 9-12,37-39: ")
# for test only
pinComboIn = "9-12"
#
pinCombos = [x.strip() for x in pinComboIn.split(',')]

# ask for specific date
print("What days are you looking for in specific?")
datesIn = input("Type required days with comma (mmddyy); e.g. 010119,123119: ")
# for test only
datesIn = "012119"
#
datesList = [x.strip() for x in datesIn.split(',')]

# read the master file
df1 = pd.read_excel(name)
print(df1.head(10))
print(df1.dtypes)

# figure counter
n = 0

# Bode plot for each impedance parameter
# for each run with legend of DUT name
# One plot for good, one for bad
for i in pinCombos:
    for j in datesList:
        df = df1[(df1["Date"].str.contains(j)) & (df1["pinCombination"].str.contains(i))]
        for date in datesList:
            plt.figure(n)
            n = n + 1
            print(n)
            plt.autoscale(enable=True, axis='both')
            plt.loglog(df["Zreal"], df["Zimag"])
            plt.xscale('symlog')
            plt.yscale('symlog')
            plt.xlabel("Zreal")
            plt.ylabel("Zimag")
            titleOfPlot = "Nyquist response - " + j + " " + i
            plt.title(titleOfPlot)
            plt.legend()
            plt.savefig(titleOfPlot + ".svg")
            # plt.show()

