FUNCTION: GolfIn::Detection::ClubDetection::performDetectionPipeline
ENTRY: 180086de0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: virtual void __cdecl GolfIn::Detection::ClubDetection::performDetectionPipeline(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::performDetectionPipeline
          (ClubDetection *this,ClubDetectionInput *param_1)

{
  int iVar1;
  undefined1 auStack_b8 [32];
  undefined8 local_98 [4];
  undefined8 local_78;
  undefined8 uStack_70;
  undefined8 local_68;
  undefined8 uStack_60;
  undefined8 local_58;
  undefined8 uStack_50;
  undefined8 local_48;
  undefined8 uStack_40;
  undefined8 local_38;
  undefined8 uStack_30;
  undefined8 local_28;
  undefined8 uStack_20;
  ulonglong local_18;
  
                    /* 0x86de0  849
                       ?performDetectionPipeline@ClubDetection@Detection@GolfIn@@MEAAXAEBUClubDetectionInput@23@@Z
                        */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_b8;
  *(undefined4 *)(this + 0x80) = *(undefined4 *)(param_1 + 0x20);
                    /* WARNING: Load size is inaccurate */
  extractEstimatedBoundingRelativeToBall
            (*(ClubDetection **)(param_1 + 0xe8),*(undefined8 *)(param_1 + 0xe8),
             *(undefined4 *)(param_1 + 0xf0),
             CONCAT44(**(undefined4 **)(param_1 + 0x68),(*(undefined4 **)(param_1 + 0x68))[1]));
  local_78 = 0;
  uStack_70 = 0;
  local_68 = 0;
  uStack_60 = 0;
  local_58 = 0;
  uStack_50 = 0;
  local_48 = 0;
  uStack_40 = 0;
  local_38 = 0;
  uStack_30 = 0;
  local_28 = 0;
  uStack_20 = 0;
  cv::Mat::Mat((Mat *)&local_78);
  iVar1 = *(int *)(param_1 + 0x10c);
  if (iVar1 == 1) {
    extractMaskMOG2(this,param_1,(Mat *)&local_78);
  }
  else if (iVar1 == 2) {
    extractMaskREMBG(this,param_1,(Mat *)&local_78);
  }
  else {
    if (iVar1 != 3) {
      FUN_180009760(local_98,"Invalid detection method.");
                    /* WARNING: Subroutine does not return */
      _CxxThrowException(local_98,(ThrowInfo *)&DAT_1801a9018);
    }
    extractMaskHED(this,param_1,(Mat *)&local_78);
  }
  refineClubMask(this,param_1);
  extractClubCentroid(this);
  if (this[0xd0] != (ClubDetection)0x0) {
    saveMaskResults(this,param_1,(Mat *)&local_78);
  }
  cv::Mat::~Mat((Mat *)&local_78);
  return;
}

