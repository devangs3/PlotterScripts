# rename files for Zurich data CSVs inside a folder with a given name
import os

for root, dirs, files in os.walk("C:/Users/Devang/Box Sync/TI_Temp_Cycling_Project/Data/01212019_Zurich"):
    if not files:
        continue
    prefix = os.path.basename(root)
    for f in files:
        # os.rename(os.path.join(root, f), os.path.join(root, "{}_{}".format(prefix, f)))
        os.rename(os.path.join(root, f), format(prefix, f))

