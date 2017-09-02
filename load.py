import json
import os

'''
Load all countries into memory as json
'''
def load(fpath='./factbook.json'):
    countries = {}
    for root, dirs, files in os.walk(fpath):
        for filename in files:
            if '.json' in filename and len(filename) == 7:
                #print(root+'/'+filename)
                with open(root+'/'+filename) as f:
                    countries[ filename[:2] ] = json.load(f)

    return countries

countries = load()

# Example
print(countries['au']['Geography']['Area'])
