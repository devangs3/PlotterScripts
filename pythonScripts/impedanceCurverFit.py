from impedance import preprocessing
from impedance.models.circuits import Randles, CustomCircuit
import matplotlib.pyplot as plt
from impedance.visualization import plot_nyquist, plot_bode

# Load data from the example EIS result
frequencies, Z = preprocessing.readGamry('1618940354_SWR90456_S1_C1_9_12_POT_659.5_#5.dta')

# keep only the impedance data in the first quadrant
frequencies, Z = preprocessing.ignoreBelowX(frequencies, Z)

# see sample-ckt.jpeg image in folder for reference
circuit = 'R0-p(p(R1,p(R2,C0)),C1)'
initial_guess = [500, .01, 100, .01, .05]
circuit = CustomCircuit(circuit, initial_guess=initial_guess)
circuit.fit(frequencies, Z)

randles = Randles(initial_guess=[7e3, 7e3, 2e-6, .5, 6e3, 2e-6], CPE=True)
randles.fit(frequencies, Z)

Z_fit = circuit.predict(frequencies)
Z_fit2 = randles.predict(frequencies)

# nyquist
fig, ax = plt.subplots(figsize=(6, 6))
plot_nyquist(ax, Z, fmt='o')
plot_nyquist(ax, Z_fit2, fmt='-')
plt.legend(['Data', 'Fit'])
plt.show()

# bode
fig, ax = plt.subplots(nrows=2, figsize=(6, 6))
plot_bode(ax, frequencies, Z, fmt='o')
plot_bode(ax, frequencies, Z_fit2, fmt='-')
plt.legend(['Data', 'Fit'])
plt.show()

# print(circuit)
print(randles)
# print(frequencies)
# print(Z)
# print(type(str(randles)))
