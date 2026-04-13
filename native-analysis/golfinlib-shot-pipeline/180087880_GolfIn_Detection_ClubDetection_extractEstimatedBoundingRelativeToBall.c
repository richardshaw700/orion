FUNCTION: GolfIn::Detection::ClubDetection::extractEstimatedBoundingRelativeToBall
ENTRY: 180087880
REASONS: name:club


/* protected: void __cdecl
   GolfIn::Detection::ClubDetection::extractEstimatedBoundingRelativeToBall(class
   cv::Point_<float>,int,class cv::Size_<int>) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::extractEstimatedBoundingRelativeToBall
          (ClubDetection *this,undefined8 param_2,int param_3,undefined8 param_4)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  float fVar6;
  float fVar7;
  float local_18;
  float fStack_14;
  
                    /* 0x87880  568
                       ?extractEstimatedBoundingRelativeToBall@ClubDetection@Detection@GolfIn@@IEAAXV?$Point_@M@cv@@HV?$Size_@H@5@@Z
                        */
  fStack_14 = (float)((ulonglong)param_2 >> 0x20);
  fVar6 = (float)param_3;
  fVar7 = fVar6 * DAT_18017ec24;
  local_18 = (float)param_2;
  fVar6 = (float)(int)((fStack_14 - fVar7 * DAT_18017e97c) - (fVar6 + fVar6));
  *(float *)(this + 0x70) = (float)(int)(local_18 - fVar7 * DAT_18017e97c);
  *(float *)(this + 0x74) = fVar6;
  *(float *)(this + 0x78) = fVar7;
  *(float *)(this + 0x7c) = fVar7;
  iVar1 = (int)ROUND(fVar6);
  iVar2 = (int)ROUND(fVar7);
  iVar3 = (int)ROUND(fVar7);
  if (iVar1 < 0) {
    iVar1 = 0;
  }
  iVar5 = (int)ROUND(*(float *)(this + 0x70));
  if ((int)ROUND(*(float *)(this + 0x70)) < 0) {
    iVar5 = 0;
  }
  if ((int)param_4 < iVar5 + iVar3) {
    iVar3 = (int)param_4 - iVar5;
  }
  iVar4 = (int)((ulonglong)param_4 >> 0x20);
  if (iVar4 < iVar1 + iVar2) {
    iVar2 = iVar4 - iVar1;
  }
  *(float *)(this + 0x70) = (float)iVar5;
  *(float *)(this + 0x74) = (float)iVar1;
  *(float *)(this + 0x78) = (float)iVar3;
  *(float *)(this + 0x7c) = (float)iVar2;
  return;
}

