#pragma once
#include "cyclicList.h"

CyclicList *createCyclicList();

//Add warriors in cyclic list
void addWarriors(CyclicList *cyclicList, int n);

//Kill warriors 'til only one is left
int killing(CyclicList *cyclicList, int m);