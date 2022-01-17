import sys
import argparse
import numpy as np
import pandas as pd
from sklearn.decomposition import PCA
from sklearn.preprocessing import MinMaxScaler

def createParser():
    parser = argparse.ArgumentParser()
    parser.add_argument('excelPath')
    parser.add_argument('excelSheet')
    parser.add_argument('pcaResultsPath')
    parser.add_argument('dataCSVPath')
    return parser

if __name__ == "__main__":
    parser = createParser()
    arguments = parser.parse_args(sys.argv[1:])
    scaler = MinMaxScaler((-1, 1))
    df = pd.ExcelFile(arguments.excelPath)
    #print(df.sheet_names)
    df_1 = df.parse(arguments.excelSheet)
    df_1_ = scaler.fit_transform(df_1)
    ff = open(arguments.dataCSVPath,"w")
    f=open(arguments.pcaResultsPath, "w")
    df_1.to_csv(arguments.dataCSVPath)
    ff.close()
    pca = PCA(n_components='mle', svd_solver='full')
    model = pca.fit(df_1_)
    for i, component in enumerate(pca.components_):
        f.write(str(round(100 * pca.explained_variance_ratio_[i], 2)) + "\r\n")
        f.write(str(pca.components_[i])+ "\r\n")
    f.close()
