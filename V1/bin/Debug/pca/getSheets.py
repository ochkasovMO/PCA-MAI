import sys
import argparse
import numpy as np
import pandas as pd

def createParser():
    parser = argparse.ArgumentParser()
    parser.add_argument('excelPath')
    parser.add_argument('sheetsFile')
    return parser

if __name__ == "__main__":
    parser = createParser()
    arguments = parser.parse_args(sys.argv[1:])
    df = pd.ExcelFile(arguments.excelPath)
    f = open(arguments.sheetsFile, "w")
    f.write(str(df.sheet_names))
    f.close()
