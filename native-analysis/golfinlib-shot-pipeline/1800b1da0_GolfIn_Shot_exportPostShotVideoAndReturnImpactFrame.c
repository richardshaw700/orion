FUNCTION: GolfIn::Shot::exportPostShotVideoAndReturnImpactFrame
ENTRY: 1800b1da0
REASONS: name:exportPostShot; string:exportPostShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: int __cdecl GolfIn::Shot::exportPostShotVideoAndReturnImpactFrame(class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,bool) __ptr64 */

int __thiscall
GolfIn::Shot::exportPostShotVideoAndReturnImpactFrame
          (Shot *this,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_1,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_2,basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                   *param_3,bool param_4)

{
  uint *puVar1;
  undefined **ppuVar2;
  double dVar3;
  bool bVar4;
  float fVar5;
  float fVar6;
  float fVar7;
  int iVar8;
  uint *puVar9;
  bool bVar10;
  int iVar11;
  int iVar12;
  Frame *this_00;
  ulonglong uVar13;
  int *piVar14;
  undefined8 uVar15;
  longlong *plVar16;
  longlong lVar17;
  uint *puVar18;
  LPSTR pCVar19;
  undefined8 *puVar20;
  LPCWSTR ***ppppWVar21;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar22;
  uint ****ppppuVar23;
  int iVar24;
  uint *puVar25;
  uint *puVar26;
  int iVar27;
  undefined1 auStackY_2a8 [32];
  LPCWSTR **local_270;
  undefined8 uStack_268;
  undefined8 local_260;
  ulonglong uStack_258;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_248;
  undefined8 uStack_240;
  undefined8 local_238;
  undefined8 local_230;
  undefined8 local_228;
  undefined8 *local_220;
  undefined8 local_218;
  int local_210;
  int iStack_20c;
  Shot *local_208;
  uint ***local_200 [2];
  longlong local_1f0;
  ulonglong local_1e8;
  WCHAR local_1e0 [20];
  undefined1 local_1b8 [8];
  Mat local_1b0 [104];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_148;
  undefined **ppuStack_140;
  longlong local_138;
  undefined8 *local_128;
  undefined8 *puStack_120;
  longlong local_118;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
  undefined8 local_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 uStack_c0;
  undefined8 local_b8;
  undefined8 uStack_b0;
  VideoWriter local_a8 [40];
  ulonglong local_80;
  
                    /* 0xb1da0  556
                       ?exportPostShotVideoAndReturnImpactFrame@Shot@GolfIn@@QEAAHAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@4@0_N@Z
                        */
  local_80 = DAT_1801d1040 ^ (ulonglong)auStackY_2a8;
  local_208 = this;
  this_00 = (Frame *)FUN_180092d40((longlong *)param_2,(undefined8 *)param_3);
  Libraries::CamerasCore::Frame::getCaptureRect(this_00);
  iVar12 = (int)uStack_240;
  local_210 = (int)uStack_240;
  iVar8 = uStack_240._4_4_;
  iStack_20c = uStack_240._4_4_;
  uStack_240 = *(Mat **)(param_1 + 0x10);
  local_248 = param_1;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    local_248 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                 param_1;
  }
  uVar13 = FUN_180130f54();
  FUN_180025df0(local_1e0,(UINT)uVar13,&local_248);
  bVar10 = false;
  piVar14 = FUN_180024bf0((int *)&local_248,local_1e0,3);
  local_228 = *(undefined8 *)piVar14;
  local_148 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              CONCAT44(local_148._4_4_,piVar14[2]);
  ppuStack_140 = &PTR_vftable_1801d10b8;
  if ((int)local_228 == 0) {
    if (piVar14[2] != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_180025990("exists",&local_148,(undefined8 *)local_1e0);
    }
  }
  else if ((int)local_228 != 1) {
    ppuVar2 = *(undefined ***)(param_1 + 0x10);
    pbVar22 = param_1;
    if (0xf < *(ulonglong *)(param_1 + 0x18)) {
      pbVar22 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                 param_1;
    }
    uVar13 = FUN_180130f54();
    local_148 = pbVar22;
    ppuStack_140 = ppuVar2;
    FUN_180025df0((LPWSTR)&local_270,(UINT)uVar13,&local_148);
    bVar10 = true;
    ppppWVar21 = &local_270;
    if (7 < uStack_258) {
      ppppWVar21 = (LPCWSTR ***)local_270;
    }
    uVar15 = FUN_180131ad4((LPCWSTR)ppppWVar21);
    iVar27 = (int)((ulonglong)uVar15 >> 0x20);
    if (iVar27 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_180069bc0("remove",iVar27,&local_270);
    }
    if ((char)uVar15 == '\0') {
      bVar4 = true;
      goto LAB_1800b1f06;
    }
  }
  bVar4 = false;
LAB_1800b1f06:
  if (bVar10) {
    FUN_180025f40((longlong *)&local_270);
  }
  FUN_180025f40((longlong *)local_1e0);
  if (bVar4) {
    plVar16 = FUN_1800014c0();
    local_270 = (LPCWSTR **)0x0;
    uStack_268 = 0;
    local_260 = 0;
    uStack_258 = 0;
    FUN_18000c1d0(&local_270,"Failed to remove the previous post shot video!",0x2e);
    FUN_180084c00(plVar16,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_270,3,'\x01');
    iVar12 = -1;
  }
  else {
    iVar27 = *(int *)(this + 0x24);
    dVar3 = floor((double)iVar27 - _DAT_18017eb90);
    iVar24 = (int)dVar3;
    dVar3 = ceil((double)iVar27 + _DAT_18017eb90);
    iVar27 = (int)dVar3;
    if (iVar24 < 0) {
      iVar11 = -iVar24;
      if (-iVar24 < 0) {
        iVar11 = iVar24;
      }
      iVar27 = iVar27 + iVar11;
    }
    if (iVar24 < 0) {
      iVar24 = 0;
    }
    if (*(int *)(this_00 + 0xa8) + -1 < iVar27) {
      iVar27 = *(int *)(this_00 + 0xa8) + -1;
    }
    local_128 = (undefined8 *)0x0;
    puStack_120 = (undefined8 *)0x0;
    local_118 = 0;
    FUN_180008f50((ulonglong *)&local_128,2);
    *local_128 = 0x3200000001;
    puStack_120 = local_128 + 1;
    iVar11 = cv::VideoWriter::fourcc('M','J','P','G');
    cv::VideoWriter::VideoWriter(local_a8,param_1,iVar11,DAT_18017eb58);
    fVar7 = DAT_18017ec28;
    fVar6 = DAT_18017ea00;
    fVar5 = DAT_18017e9c0;
    for (; iVar24 <= iVar27; iVar24 = iVar24 + 1) {
      lVar17 = Libraries::CamerasCore::Frame::GetImage(this_00,(int)local_1b8);
      bVar10 = cv::Mat::empty((Mat *)(lVar17 + 8));
      if (((!bVar10) && ((*(int **)(lVar17 + 0x48))[1] == iVar12)) &&
         (**(int **)(lVar17 + 0x48) == iVar8)) {
        local_148 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    0x0;
        ppuStack_140 = (undefined **)0x0;
        local_138 = 0;
        local_238 = 0;
        local_248._0_4_ = 0x1010000;
        local_270 = (LPCWSTR **)0x0;
        uStack_268 = 0;
        local_260 = 0;
        uStack_258 = 0;
        uStack_240 = (Mat *)(lVar17 + 8);
        FUN_18000c1d0(&local_270,&DAT_180174458,4);
        cv::imencode((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_270,(_InputArray *)&local_248,
                     (vector<unsigned_char,class_std::allocator<unsigned_char>_> *)&local_148,
                     (vector<int,class_std::allocator<int>_> *)&local_128);
        FUN_18000c8d0((longlong *)&local_270);
        local_108 = 0;
        uStack_100 = 0;
        local_f8 = 0;
        uStack_f0 = 0;
        local_e8 = 0;
        uStack_e0 = 0;
        local_d8 = 0;
        uStack_d0 = 0;
        local_c8 = 0;
        uStack_c0 = 0;
        local_b8 = 0;
        uStack_b0 = 0;
        local_238 = 0;
        local_248 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    CONCAT44(local_248._4_4_,0x81030000);
        uStack_240 = (Mat *)&local_148;
        cv::imdecode((_InputArray *)&local_108,(int)&local_248);
        if (param_4) {
          Libraries::Core::equilizeAdjustContrastBrightness
                    ((Mat *)&local_108,(Mat *)&local_108,fVar5,fVar6,fVar7);
        }
        local_218 = 0;
        local_228 = CONCAT44(local_228._4_4_,0x1010000);
        local_220 = &local_108;
        cv::VideoWriter::write(local_a8,(_InputArray *)&local_228);
        cv::Mat::~Mat((Mat *)&local_108);
        if (local_148 !=
            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) {
          pbVar22 = local_148;
          if ((0xfff < (ulonglong)(local_138 - (longlong)local_148)) &&
             (pbVar22 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          **)(local_148 + -8),
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x1f <
             local_148 + (-8 - (longlong)pbVar22))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pbVar22);
          local_148 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)0x0;
          ppuStack_140 = (undefined **)0x0;
          local_138 = 0;
        }
      }
      cv::Mat::~Mat(local_1b0);
    }
    cv::VideoWriter::release(local_a8);
    plVar16 = FUN_1800014c0();
    uVar15 = *(undefined8 *)(param_1 + 0x10);
    if (0xf < *(ulonglong *)(param_1 + 0x18)) {
      param_1 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                 param_1;
    }
    uVar13 = FUN_180130f54();
    local_148 = param_1;
    ppuStack_140 = (undefined **)uVar15;
    FUN_180025df0((LPWSTR)local_200,(UINT)uVar13,&local_148);
    ppppuVar23 = local_200;
    if (7 < local_1e8) {
      ppppuVar23 = (uint ****)local_200[0];
    }
    puVar25 = (uint *)((longlong)ppppuVar23 + local_1f0 * 2);
    puVar26 = puVar25;
    puVar18 = FUN_180068eb0((uint *)ppppuVar23,puVar25);
    if (puVar18 != puVar26) {
      do {
        puVar9 = puVar25;
        puVar1 = puVar26;
        if (((short)*puVar18 != 0x5c) && ((short)*puVar18 != 0x2f)) break;
        puVar18 = (uint *)((longlong)puVar18 + 2);
      } while (puVar18 != puVar26);
      do {
        puVar25 = puVar9;
        if (puVar18 == puVar1) break;
        puVar1 = (uint *)((longlong)puVar25 + -2);
        if ((*(short *)puVar1 == 0x5c) || (puVar9 = puVar1, *(short *)puVar1 == 0x2f)) break;
      } while( true );
    }
    local_248 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
    uStack_240 = (Mat *)0x0;
    local_238 = 0;
    local_230 = 0;
    FUN_1800697d0(&local_248,puVar25,(longlong)puVar26 - (longlong)puVar25 >> 1);
    pCVar19 = FUN_180093600((LPCWSTR)&local_248,(LPSTR)local_1e0);
    puVar20 = FUN_180007680((undefined8 *)pCVar19,0,
                            "[Save.ExportPostShotVideo] Save post shot video >> ",0x33);
    local_270 = (LPCWSTR **)*puVar20;
    uStack_268 = puVar20[1];
    local_260 = puVar20[2];
    uStack_258 = puVar20[3];
    puVar20[2] = 0;
    puVar20[3] = 0xf;
    *(undefined1 *)puVar20 = 0;
    FUN_180084c00(plVar16,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_270,1,'\x01');
    FUN_18000c8d0((longlong *)local_1e0);
    FUN_180025f40((longlong *)&local_248);
    FUN_180025f40((longlong *)local_200);
    iVar12 = *(int *)(local_208 + 0x24);
    cv::VideoWriter::~VideoWriter(local_a8);
    if (local_128 != (undefined8 *)0x0) {
      puVar20 = local_128;
      if ((0xfff < (local_118 - (longlong)local_128 & 0xfffffffffffffffcU)) &&
         (puVar20 = (undefined8 *)local_128[-1],
         0x1f < (ulonglong)((longlong)local_128 + (-8 - (longlong)puVar20)))) {
                    /* WARNING: Subroutine does not return */
        _invalid_parameter_noinfo_noreturn();
      }
      free(puVar20);
    }
  }
  return iVar12;
}

