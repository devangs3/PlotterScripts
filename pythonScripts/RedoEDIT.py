# Richard Willis, 2018
import os, sys, xlsxwriter, csv, math, statistics
import numpy as np

frequencies_for_sheets = ["0.999041", "5.008013", "9.93114", "19.86229", "39.72458", "49.86702", "63.3446", "79.00281", "100.4464", "198.6229", "315.5048", "505.5147", "998.264", "1577.524"]
percent_change_sheets = ["Percent Change - Zreal", "Percent Change - Zimag", "Percent Change - Zmod"] #sheet names for percent change stuff

class datafile:
    def __init__(self, f):
        if person == 2: #Badri
            self.f = f
            self.name = f
            self.filenamelist = f.split("_")
            self.chip = self.filenamelist[1]
            self.cortisol = ""
            self.HS = ""
            if self.filenamelist[3] == "dose":
                self.dose = self.filenamelist[4]
                self.trial = self.filenamelist[5]
            else:
                self.dose = self.filenamelist[2] + "_" + self.filenamelist[3]
                self.trial = self.filenamelist[4]
            self.trial = int(self.trial[1])
            self.test = "EIS"
            self.averagefilename = "Average_" + self.chip + "_" + self.dose + ".csv"
            self.worksheetname = self.chip + "_" + self.dose
            self.averagefilepath = indir + "\\" + self.averagefilename
        
        with open(indir + "\\" + self.name, 'r') as self.rawfile:
            print(self.name)
            self.csvobject = csv.reader(self.rawfile, csv.excel_tab)
            self.reader = list(self.csvobject)
            for i in range(len(self.reader)): #attempt to convert each cell in column 1 to float type
                try: #if successful, print row index where data starts
                    floater1 = (float(self.reader[i][5])) 
                    column1ind = i
                    break
                except: pass
            for i in range(len(self.reader)): 
                try:
                    floater2 = (float(self.reader[i][6]))
                    column2ind = i
                    crapindex=0
                    break
                except: pass
            self.datarow = column1ind
            self.array = self.reader
            self.array = self.array[column1ind - 2: len(self.array)]

            if self.test == "EIS": #cut unncessary columns from each file type
                cutout = [11, 10, 9, 6, 0]
                for k in cutout:
                    self.array = np.delete(self.array, k, 1)
            elif self.test == "CA":
                cutout = [9,8,7,6,5,3,0]
                for k in cutout:
                    self.array = np.delete(self.array, k, 1)
            try: self.array = self.array.tolist()
            except: pass
            if self.test == "EIS":
                degree_sign= u'\N{DEGREE SIGN}'
                Xc = ["Xc", degree_sign]
                for row in range(2, len(self.array)):
                    Xc.append(1/(float(2*math.pi)*float(self.array[row][4])*float(self.array[row][2])))
                for row in range(len(self.array)):
                    self.array[row].append(Xc[row])
        self.nparray=np.asarray(self.array)
            
    def printName(self):
        print(self.name)

    def printArray(self):
        print(self.array)

class experiment:
    pt = 0
    time = 1
    freq = 2
    zreal = 3
    zimag = 4
    zmod = 5
    zphz = 6
    xc = 7
    
    def __init__(self, files):
        self.files = files
        self.array = []
        self.test = files[0].test
        self.headers = files[0].array[0:1]
        self.averagefilename = self.files[0].averagefilename
        self.worksheetname = self.files[0].worksheetname
        self.averagefilepath = self.files[0].averagefilepath
        self.trio = self.files[0].array
        self.trio = np.expand_dims(self.trio, axis=2)
        
        for file in self.files:
            if file.trial > 1:
                file.nparray = np.expand_dims(file.nparray, axis=2)
                self.trio = np.append(self.trio, file.nparray, axis=2)

    def calcAverages(self):
        self.average = np.copy(self.files[0].array)
        for row in range(2, len(self.trio)):
            for col in range(len(self.trio[0])):
                forAvg = []
                for file in self.files:
                    forAvg.append(float(file.array[row][col]))
                self.average[row][col] = statistics.mean(forAvg)
        self.average = np.array(self.average)

        self.csvArray = self.average
        cutout = [0,1,7]
        self.csvArray = np.delete(self.csvArray, cutout, axis = 1)
    def calcStdDev(self):
        if len(self.files) > 1:
            self.StdDev = np.copy(self.files[0].nparray)
            for row in range(2, len(self.trio)):
                for col in range(len(self.trio[0])):
                    forStdDev = []
                    for file in self.files:
                        forStdDev.append(float(file.array[row][col]))
                    self.StdDev[row][col] = statistics.stdev(forStdDev)
            self.StdDev=np.array(self.StdDev)
    def writeCSVs(self):
        with open(self.averagefilepath, 'w') as averagefile:
            csvwriter = csv.writer(averagefile, delimiter=',',quotechar='|', quoting=csv.QUOTE_MINIMAL, lineterminator = '\n')
            for row in self.csvArray:
                csvwriter.writerow(row)
                
    def addToSummaryFile(self):
        activeWorksheet = summaryfile.add_worksheet(self.worksheetname)
        columnPosition = 0 #position in excel file
        for file in self.files:
            activeWorksheet.write(0, columnPosition, "Trial " + str(file.trial))
            columnPosition = writeToFile(file.array, activeWorksheet, columnPosition, "Trial " + str(file.trial))
        avgPos = columnPosition
        columnPosition = writeToFile(self.average, activeWorksheet, columnPosition, "Average")
        
        if self.test == "EIS":
            addToChart(self, zmodvsfreq, avgPos, self.freq, self.zmod)
            addToChart(self, zphzvsfreq, avgPos, self.freq, self.zphz)
            addToChart(self, zimagvszreal, avgPos, self.zreal, self.zimag)
            addToChart(self, zimagvsfreq, avgPos, self.freq, self.zimag)
            addToChart(self, zrealvsfreq, avgPos, self.freq, self.zreal)
            
            izmodvsfreq = setzmodvsfreq()
            izphzvsfreq = setzphzvsfreq()
            izimagvszreal = setzimagvszreal()
            izimagvsfreq = setzimagvsfreq()
            izrealvsfreq = setzrealvsfreq()

            
            addToChart(self, izmodvsfreq, avgPos, self.freq, self.zmod)
            addToChart(self, izphzvsfreq, avgPos, self.freq, self.zphz)
            addToChart(self, izimagvszreal, avgPos, self.zreal, self.zimag)
            addToChart(self, izimagvsfreq, avgPos, self.freq, self.zimag)
            addToChart(self, izrealvsfreq, avgPos, self.freq, self.zreal)

            activeWorksheet.insert_chart('A4', izmodvsfreq)
            activeWorksheet.insert_chart('J4', izphzvsfreq)
            activeWorksheet.insert_chart('A20', izimagvszreal)
            activeWorksheet.insert_chart('A22', izimagvsfreq)
            activeWorksheet.insert_chart('A24', izrealvsfreq)
        if len(self.files) > 1 and person != 5:
            columnPosition = writeToFile(self.StdDev, activeWorksheet, columnPosition, "Standard Deviation")

    def badriPhaseFind(self, sheet, rowposition):
        self.csvArray = list(self.csvArray)
        freq = self.csvArray[0][0]
        hz = self.csvArray[1][0]
        desiredFrequencies = []
        position = 0 - len(desiredFrequencies)
        for i in range(2, len(self.csvArray)):
            if -90 < float(self.csvArray[i][4]) < -50 and float(self.csvArray[i][0]) < 1000:
                sheet.write(rowposition, 0, self.worksheetname)
                for col in range(len(self.csvArray[i])):
                    sheet.write_number(rowposition, col + 1, float(self.csvArray[i][col]))
                rowposition = rowposition + 1
        return rowposition

    def write_frequency_sheets(self, row): #add experiment to frequency sheets
        for freq in frequencies_for_sheets:
            worksheet = summaryfile.get_worksheet_by_name(freq)
            worksheet.write(row, 0, self.worksheetname)
            headers = ["Freq", "Zreal", "Zimag", "Zmod", "Zphz"]
            for col in range(len(headers)):
                worksheet.write(0, col+1, headers[col])
            for avg_row in self.csvArray:
                if avg_row[0] == freq:
                    for col in range(len(avg_row)):
                        worksheet.write_number(row, col + 1, float(avg_row[col]))
        return row + 1
       
def writeToFile(array, worksheet, columnPosition, title):
    rowoffset = 1 #how much each dataset is pushed down
    width = 0 #variable to hold the width of each dataset
    worksheet.write(0, columnPosition, title)
    for col in range(len(array[0])):
        for row in range(len(array)):
            if row > 1: 
                worksheet.write_number(row + rowoffset, col+columnPosition, float(array[row][col]))
            else:
                worksheet.write(row + rowoffset, col+columnPosition, array[row][col])
        width = width + 1
    columnPosition = columnPosition + width + 1
    width = 0
    return columnPosition

def addToChart(self, chart1, avgPos, xcol, ycol):
    xcol = excelcol(xcol+avgPos)
    ycol = excelcol(ycol+avgPos)
    stop = str(len(self.files[0].array) + 1)
    x = "='" + self.worksheetname + "'!$" + xcol + "$4:$" + xcol + "$" + stop
    y = "='" + self.worksheetname + "'!$" + ycol + "$4:$" + ycol + "$" + stop
    chart1.add_series({
        'name': self.worksheetname,
        'categories': x,
        'values': y,
    })

def excelcol(col):
    LETTERS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
    col = col + 1
    """ Convert given row and column number to an Excel-style cell name. """
    result = []
    while col:
        col, rem = divmod(col-1, 26)
        result[:0] = LETTERS[rem]
    return ''.join(result)

def setzmodvsfreq():
    chart = summaryfile.add_chart({'type': 'scatter', 'subtype': 'straight'})
    chart.set_x_axis({'reverse': False, 'name': "Frequency (Hz)", 'log_base': 10})
    chart.set_y_axis({'log_base': 10, 'name': "Zmod (Ohms)"})
    chart.set_title({'name': 'Zmod vs. Freq'})
    return chart

def setzphzvsfreq():
    chart = summaryfile.add_chart({'type': 'scatter', 'subtype': 'straight'})
    chart.set_x_axis({'reverse': False, 'log_base': 10, 'name': "Frequency (Hz)"})
    chart.set_y_axis({'name': "ZPhz (Ohms)"})
    chart.set_title({'name': 'ZPhz vs. Freq'})
    return chart
	
def setzimagvsfreq():
    chart = summaryfile.add_chart({'type': 'scatter', 'subtype': 'straight'})
    chart.set_x_axis({'reverse': False, 'name': "Frequency (Hz)", 'log_base': 10})
    chart.set_y_axis({'-log_base': 10, 'name': "Zimag (Ohms)"})
    chart.set_title({'name': 'Zimag vs. Freq'})
    return chart

def setzrealvsfreq():
    chart = summaryfile.add_chart({'type': 'scatter', 'subtype': 'straight'})
    chart.set_x_axis({'reverse': False, 'name': "Frequency (Hz)", 'log_base': 10})
    chart.set_y_axis({'log_base': 10, 'name': "Zreal (Ohms)"})
    chart.set_title({'name': 'Zreal vs. Freq'})
    return chart
	
def setzimagvszreal():
    chart = summaryfile.add_chart({'type': 'scatter', 'subtype': 'straight'})
    chart.set_x_axis({'name': "ZReal", 'min' : 0})
    chart.set_y_axis({'name': "ZImag"})
    chart.set_title({'name': 'ZImag vs. ZReal'})
    return chart

def make_freq_sheets(freqs): #create the sheets for the frequency sheets
    freq_worksheets = []
    for freq in freqs:
        freq_worksheets.append(summaryfile.add_worksheet(freq))
    return freq_worksheets

def make_average_sheet():
    averages_worksheet = summaryfile.add_worksheet("Averages")
    header1 = ["Zreal", "Zimag", "Zmod", "Zphz", "Xc"]
    header2 = ["Ohm", "Ohm", "Ohm", "deg", "deg"]
    for col in range(len(header1)):
        worksheet.write(0, col+1, header1[col])
        worksheet.write(1, col+1, header2[col])
    return averages_worksheet           
                
indir = input("Enter a path to the folder with data: ")
#indir = r"C:\Users\seawa\Documents\BMNL" #change this to your path, but don't delete the r
summaryfilename = 'Summary.xlsx'
summaryfile = xlsxwriter.Workbook(indir + "\\" + summaryfilename)                
datafiles = [] #list of all files as datafile objects
EISflag = 0 #makes sure there is at least one EIS graph so it doesn't try to add an empty chart
#person = int(input("Enter the number corresponding to your name: \n 2. Badri"))
person = 2
lr = 0
if person == 2 or person == 4:
    print("If you want to run left/right data separately,")
    lr = int(input("enter -1 for left, 1 for right, or 0 if you want to run all your files together"))
for root, dirs, files in os.walk(indir): #add files to datafiles array as datafile objects
    if lr == 0:
        for f in files:
            if f.endswith(".xls") or f.endswith(".DTA"):
                datafiles.append(datafile(f))
    if lr == 1:
        for f in files:
            if f.endswith(".xls") and ("_R_" in f):
                datafiles.append(datafile(f))
    if lr == -1:
        for f in files:
            if f.endswith(".xls") and ("_L_" in f):
                datafiles.append(datafile(f))
            
trialsperrun = 0 #find trials per run
for file in datafiles:
    if file.test == "EIS":
        EISflag = 1
    if file.trial > trialsperrun:
        trialsperrun = file.trial
    if file.trial < trialsperrun:
        break
    
experiments = [] #pairs up all the files into experiment objects which are placed in the list 'experiments'
count = 0
listForExp = []
for file in datafiles:
    listForExp.append(file)
    count = count + 1
    if count == trialsperrun:
        exp = experiment(listForExp)
        experiments.append(exp)
        count = 0
        listForExp = []
    
zmodvsfreq = setzmodvsfreq() #create charts
zphzvsfreq = setzphzvsfreq()
zimagvszreal = setzimagvszreal()
zimagvsfreq = setzimagvsfreq()
zrealvsfreq = setzrealvsfreq()

if person == 2:
    allandaverageflagambalika = "n"
    if person == 2:
        phaseDataSheet = summaryfile.add_worksheet("Phase Summary")
        phaseDataPosition = 3
        writeToFile([["Assay Steps", "Freq", "Zreal", "Zimag", "Zmod", "Zphz"], ["", "Hz", "Ohms", "Ohms", "Ohms", u'\N{DEGREE SIGN}']], phaseDataSheet, 0, "-50" + u'\N{DEGREE SIGN}' +"< Zphz < 90" + u'\N{DEGREE SIGN}')
        for i in range(len(experiments)):
            print(str(i+1) + ".", experiments[i].worksheetname)
        #Manual Sorting
        print("If you don't want to sort the experiments manually, enter 0, otherwise")
        order = input("Enter the order of the experiments separated by only a space (eg. 3 6 1...): ")
        if order != "0":
            order = order.split(" ")
            if len(order) == len(experiments):
                print("New experiment order - ")
                for i in range(len(order)):
                    order[i] = int(order[i])
                new_experiments = []
                for i in range(len(order)):
                    new_experiments.append(experiments[order[i]-1])
                experiments = new_experiments
                for exp in experiments:
                    print(exp.worksheetname)
            else:
                print(len(order))
                print(len(experiments))
                print("You didn't enter enough numbers to sort the experiments; they will be processed in normal order")
            
        
        counter = 1
        phaserowposition = 1
        baselineFrequencies = frequencies_for_sheets
if person != 5:
    freq_worksheets = make_freq_sheets(frequencies_for_sheets)       
         
row = 1
average_row = 2
for experiment in experiments:
    print("")
    for file in experiment.files:
        print(file.f)
    experiment.calcAverages()
    if person != 5:
        experiment.calcStdDev()
        experiment.writeCSVs()
        row = experiment.write_frequency_sheets(row)
    experiment.addToSummaryFile()
    
    if allandaverageflagambalika == "y": #Ambalika
        allDataposition = experiment.ambalikaAllData(allDataSheet, allDataposition)
        averageDataPosition = experiment.ambalikaAverageData(averageDataSheet, averageDataPosition, desiredFrequencies)
    if person == 2: #Badri
        phaseDataPosition = experiment.badriPhaseFind(phaseDataSheet, phaseDataPosition)
        
        #average_row = experiment.add_to_average_sheet(averages_worksheet, average_row)

if EISflag == 1:
    zmodvsfreqchart = summaryfile.add_chartsheet("Zmod vs. Freq")
    zmodvsfreqchart.set_chart(zmodvsfreq)
    zphzvsfreqchart = summaryfile.add_chartsheet("ZPhz vs. Freq")
    zphzvsfreqchart.set_chart(zphzvsfreq) 
    zimagvsfreqchart = summaryfile.add_chartsheet("Zimag vs. Freq")
    zimagvsfreqchart.set_chart(zimagvsfreq)
    zrealvsfreqchart = summaryfile.add_chartsheet("Zreal vs. Freq")
    zrealvsfreqchart.set_chart(zrealvsfreq)
    zimagvszrealchart = summaryfile.add_chartsheet("Zimag vs. Zreal")
    zimagvszrealchart.set_chart(zimagvszreal)
	

summaryfile.close()