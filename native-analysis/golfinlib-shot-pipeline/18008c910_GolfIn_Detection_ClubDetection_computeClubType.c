FUNCTION: GolfIn::Detection::ClubDetection::computeClubType
ENTRY: 18008c910
REASONS: name:club; string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: virtual bool __cdecl GolfIn::Detection::ClubDetection::computeClubType(class
   GolfIn::Detection::ClubDetection const & __ptr64,float,bool) __ptr64 */

bool __thiscall
GolfIn::Detection::ClubDetection::computeClubType
          (ClubDetection *this,ClubDetection *param_1,float param_2,bool param_3)

{
  bool bVar1;
  bool bVar2;
  int iVar3;
  int iVar4;
  float *pfVar5;
  longlong *plVar6;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar7;
  undefined8 *puVar8;
  char *pcVar9;
  uint uVar10;
  undefined8 uVar11;
  size_t sVar12;
  undefined8 ***pppuVar13;
  ulonglong uVar14;
  undefined8 uVar15;
  float fVar16;
  float fVar17;
  undefined1 auStack_168 [32];
  undefined4 local_148;
  undefined4 local_140;
  double local_138;
  undefined8 **local_128;
  Mat *pMStack_120;
  undefined8 local_118;
  ulonglong uStack_110;
  longlong local_108 [4];
  Mat local_e8 [96];
  float local_88 [2];
  float local_80 [2];
  ulonglong local_78;
  
                    /* 0x8c910  464
                       ?computeClubType@ClubDetection@Detection@GolfIn@@UEAA_NAEBV123@M_N@Z */
  local_78 = DAT_1801d1040 ^ (ulonglong)auStack_168;
  uVar10 = 0;
  bVar1 = ClubDetectionInput::validateInput((ClubDetectionInput *)(this + 0xf8));
  bVar2 = false;
  if (bVar1) {
    local_118 = 0;
    local_128._0_4_ = 0x1010000;
    pMStack_120 = (Mat *)(this + 8);
    iVar3 = cv::countNonZero((_InputArray *)&local_128);
    cv::Mat::Mat(local_e8,(Mat *)(param_1 + 8));
    local_118 = 0;
    local_128 = (undefined8 **)CONCAT44(local_128._4_4_,0x1010000);
    pMStack_120 = local_e8;
    iVar4 = cv::countNonZero((_InputArray *)&local_128);
    cv::Mat::~Mat(local_e8);
    fVar16 = *(float *)(this + 0x1fc) * *(float *)(this + 0x1fc);
    fVar17 = (float)iVar3 / fVar16;
    local_88[0] = fVar17;
    fVar16 = (float)iVar4 / fVar16;
    local_80[0] = fVar16;
    if (this[0xd0] != (ClubDetection)0x0) {
      saveImageMaskAreaSquareMM(this,(Mat *)(this + 8),(int)fVar17);
      saveImageMaskAreaSquareMM(this,(Mat *)(param_1 + 8),(int)fVar16);
    }
    pfVar5 = local_80;
    if (fVar16 <= fVar17) {
      pfVar5 = local_88;
    }
    *(int *)(this + 0x88) = (int)*pfVar5;
    plVar6 = FUN_1800014c0();
    local_138 = (double)*(float *)(this + 0x1fc);
    local_140 = 6000;
    local_148 = *(undefined4 *)(this + 0x88);
    uVar14 = (ulonglong)(uint)(int)fVar16;
    pbVar7 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_108,
                        "[Club.Detection] Area mm square detected camera 1: %d and camera 2: %d. Taking %d compare to %d with a ppmm of %f."
                        ,(ulonglong)(uint)(int)fVar17,uVar14);
    uVar15 = CONCAT71((int7)(uVar14 >> 8),1);
    uVar11 = 1;
    FUN_180084c00(plVar6,pbVar7,1,'\x01');
    if (param_3) {
      uVar10 = 6;
    }
    else if (param_2 < _DAT_18017ec4c) {
      if (*(int *)(this + 0x88) < 0x1771) {
        if (0x1193 < *(int *)(this + 0x88)) {
          plVar6 = FUN_1800014c0();
          pbVar7 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                   cv::format((char *)local_108,
                              "[Club.Detection] The mask is either a wedge, wood 3, wood 5 or hybrid since his value is between %d and %d."
                              ,0x1194,6000);
          FUN_180084c00(plVar6,pbVar7,2,'\x01');
          uVar10 = 1;
          if (param_2 < DAT_18017ec3c) {
            uVar10 = 3;
          }
        }
      }
      else {
        uVar10 = 2;
      }
    }
    else {
      plVar6 = FUN_1800014c0();
      FUN_18006a0d0(local_108,(double)param_2,uVar11,uVar15);
      puVar8 = FUN_180007680(local_108,0,
                             "[Club.Detection] Analysed has an IRON. Launch angle is over the max launch angle for wood: "
                             ,0x5b);
      local_128 = (undefined8 **)*puVar8;
      pMStack_120 = (Mat *)puVar8[1];
      local_118 = puVar8[2];
      uStack_110 = puVar8[3];
      puVar8[2] = 0;
      puVar8[3] = 0xf;
      *(undefined1 *)puVar8 = 0;
      FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_128,2,'\x01');
      FUN_18000c8d0(local_108);
      uVar10 = (uint)(*(int *)(this + 0x88) - 0x1195U < 0x5db);
    }
    *(uint *)(this + 0x84) = uVar10;
    plVar6 = FUN_1800014c0();
    switch(*(undefined4 *)(this + 0x84)) {
    case 0:
      sVar12 = 0xc;
      pcVar9 = "IRON UNKNOWN";
      break;
    case 1:
      sVar12 = 5;
      pcVar9 = "WEDGE";
      break;
    case 2:
      sVar12 = 0xc;
      pcVar9 = "WOOD UNKNOWN";
      break;
    case 3:
      sVar12 = 0x12;
      pcVar9 = "SMALL FAIRWAY WOOD";
      break;
    case 4:
      sVar12 = 0x10;
      pcVar9 = "BIG FAIRWAY WOOD";
      break;
    case 5:
      sVar12 = 6;
      pcVar9 = "DRIVER";
      break;
    case 6:
      sVar12 = 6;
      pcVar9 = "PUTTER";
      break;
    default:
      sVar12 = 0xe;
      pcVar9 = "[Unknown Club]";
    }
    local_128 = (undefined8 ***)0x0;
    pMStack_120 = (Mat *)0x0;
    local_118 = 0;
    uStack_110 = 0;
    FUN_18000c1d0(&local_128,pcVar9,sVar12);
    pppuVar13 = (undefined8 ***)local_128;
    if (uStack_110 < 0x10) {
      pppuVar13 = &local_128;
    }
    pbVar7 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_108,
                        "[Club.Detection] Club type detected before specialization: %s",pppuVar13);
    FUN_180084c00(plVar6,pbVar7,1,'\x01');
    FUN_18000c8d0((longlong *)&local_128);
    bVar2 = true;
  }
  return bVar2;
}

