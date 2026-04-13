FUNCTION: FUN_1800dbca0
ENTRY: 1800dbca0
REASONS: string:Wait.For.Shot; string:Wait.For.Shot,exportPostShot; string:Wait.For.Shot,saveShot; string:Wait.For.Shot,waitForShot; string:exportPostShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

ulonglong FUN_1800dbca0(longlong *param_1)

{
  vector<int,class_std::allocator<int>_> *pvVar1;
  vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *pvVar2;
  vector<class_cv::Mat,class_std::allocator<class_cv::Mat>_> *pvVar3;
  int *piVar4;
  char cVar5;
  Interface *pIVar6;
  longlong lVar7;
  vector<int,class_std::allocator<int>_> *pvVar8;
  longlong *plVar9;
  bool bVar10;
  int iVar11;
  PlayerHandedness PVar12;
  longlong *plVar13;
  ulonglong uVar14;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *pmVar15;
  undefined8 *puVar16;
  undefined8 *puVar17;
  undefined8 *puVar18;
  undefined8 *puVar19;
  undefined8 *puVar20;
  longlong *plVar21;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar22;
  Parameter *pPVar23;
  longlong lVar24;
  tm *ptVar25;
  undefined8 ****ppppuVar26;
  ShotData *this;
  uint uVar27;
  int iVar28;
  char *pcVar29;
  undefined1 auStackY_818 [32];
  code *local_7d8;
  bool local_7d0;
  bool local_7cf;
  bool local_7ce [6];
  vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *local_7c8;
  vector<int,class_std::allocator<int>_> *local_7c0;
  longlong local_7b8;
  longlong lStack_7b0;
  longlong local_7a8;
  longlong lStack_7a0;
  longlong local_798;
  longlong lStack_790;
  longlong local_788;
  longlong lStack_780;
  longlong local_778 [4];
  longlong local_758 [4];
  longlong local_738 [4];
  longlong local_718;
  longlong lStack_710;
  longlong local_708;
  longlong lStack_700;
  undefined8 local_6f8;
  undefined8 uStack_6f0;
  undefined8 local_6e8;
  undefined8 local_6e0;
  undefined8 local_6d8;
  undefined8 uStack_6d0;
  undefined8 local_6c8;
  undefined8 local_6c0;
  longlong local_6b8;
  longlong lStack_6b0;
  longlong local_6a8;
  longlong lStack_6a0;
  undefined8 local_698;
  undefined8 uStack_690;
  undefined8 local_688;
  undefined8 local_680;
  undefined8 local_678;
  undefined8 uStack_670;
  undefined8 local_668;
  undefined8 local_660;
  undefined8 local_658;
  undefined8 uStack_650;
  undefined8 local_648;
  undefined8 local_640;
  undefined8 local_638;
  undefined8 uStack_630;
  undefined8 local_628;
  undefined8 local_620;
  undefined8 local_618;
  undefined8 uStack_610;
  undefined8 local_608;
  undefined8 local_600;
  undefined8 local_5f8;
  undefined8 uStack_5f0;
  undefined8 local_5e8;
  undefined8 local_5e0;
  undefined8 local_5d8;
  undefined8 uStack_5d0;
  undefined8 local_5c8;
  undefined8 local_5c0;
  longlong local_5b8;
  undefined8 uStack_5b0;
  undefined8 local_5a8;
  undefined8 uStack_5a0;
  longlong local_598;
  undefined8 uStack_590;
  undefined8 local_588;
  undefined8 uStack_580;
  longlong local_578;
  undefined8 uStack_570;
  undefined8 local_568;
  undefined8 uStack_560;
  longlong local_558;
  undefined8 uStack_550;
  undefined8 local_548;
  undefined8 uStack_540;
  longlong local_538;
  undefined8 uStack_530;
  undefined8 local_528;
  undefined8 uStack_520;
  longlong local_518;
  undefined8 uStack_510;
  undefined8 local_508;
  undefined8 uStack_500;
  longlong local_4f8;
  undefined8 uStack_4f0;
  undefined8 local_4e8;
  undefined8 uStack_4e0;
  longlong local_4d8;
  undefined8 uStack_4d0;
  undefined8 local_4c8;
  undefined8 uStack_4c0;
  longlong local_4b8 [4];
  longlong local_498;
  undefined8 uStack_490;
  undefined8 local_488;
  undefined8 uStack_480;
  longlong local_478;
  undefined8 *local_470 [2];
  undefined8 *local_460 [2];
  undefined8 local_450;
  undefined8 uStack_448;
  undefined4 local_440;
  undefined4 local_43c;
  undefined4 local_438;
  undefined8 local_430 [4];
  undefined8 local_410;
  undefined8 uStack_408;
  undefined1 local_400;
  undefined4 local_3fc;
  undefined4 local_3f8;
  undefined4 local_3f4;
  undefined8 local_3f0 [4];
  undefined8 local_3d0 [4];
  tm local_3b0;
  longlong local_388 [4];
  char local_368 [32];
  char local_348 [32];
  char local_328 [32];
  char local_308 [32];
  longlong local_2e8 [4];
  longlong local_2c8 [4];
  undefined **local_2a8;
  longlong local_270 [4];
  longlong local_250 [5];
  longlong *local_228;
  longlong lStack_220;
  longlong *local_218;
  longlong lStack_210;
  vector<class_cv::Mat,class_std::allocator<class_cv::Mat>_> *local_208 [2];
  undefined8 local_1f8;
  undefined8 uStack_1f0;
  undefined4 local_1e8;
  undefined4 local_1e4;
  undefined4 local_1e0;
  longlong local_1d8;
  undefined8 uStack_1d0;
  undefined8 local_1c8;
  undefined8 uStack_1c0;
  undefined8 local_1b8;
  undefined8 uStack_1b0;
  undefined1 local_1a8;
  undefined4 local_1a4;
  undefined4 local_1a0;
  undefined4 local_19c;
  longlong local_198;
  undefined8 uStack_190;
  undefined8 local_188;
  undefined8 uStack_180;
  longlong local_178;
  undefined8 uStack_170;
  undefined8 local_168;
  undefined8 uStack_160;
  undefined8 ***local_158 [2];
  size_t local_148;
  undefined8 local_140;
  longlong local_138 [2];
  basic_ostream<char,struct_std::char_traits<char>_> local_128 [8];
  basic_streambuf<char,struct_std::char_traits<char>_> local_120 [8];
  basic_iostream<char,struct_std::char_traits<char>_> local_118 [120];
  basic_ios<char,struct_std::char_traits<char>_> local_a0 [104];
  ulonglong local_38;
  
  local_38 = DAT_1801d1040 ^ (ulonglong)auStackY_818;
  bVar10 = GolfIn::Interface::loadConfigurationParameters((Interface *)*param_1);
  if (bVar10) {
    pIVar6 = (Interface *)*param_1;
    local_598 = 0;
    uStack_590 = 0;
    local_588 = 0;
    uStack_580 = 0;
    FUN_18000c1d0(&local_598,&DAT_18016a0f8,0);
    local_5b8 = 0;
    uStack_5b0 = 0;
    local_5a8 = 0;
    uStack_5a0 = 0;
    FUN_18000c1d0(&local_5b8,&DAT_18016a0f8,0);
    pmVar15 = GolfIn::Interface::grabFrames
                        (pIVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                 *)&local_5b8,
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_598);
    FUN_18000c8d0(&local_5b8);
    FUN_18000c8d0(&local_598);
    lVar24 = *param_1;
    local_578 = 0;
    uStack_570 = 0;
    local_568 = 0;
    uStack_560 = 0;
    FUN_18000c1d0(&local_578,"Camera1",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_578);
    puVar16 = FUN_180006c00((longlong *)pmVar15,plVar13);
    pvVar1 = (vector<int,class_std::allocator<int>_> *)(puVar16 + 0xf);
    FUN_18000c8d0(&local_578);
    lVar24 = *param_1;
    local_558 = 0;
    uStack_550 = 0;
    local_548 = 0;
    uStack_540 = 0;
    FUN_18000c1d0(&local_558,"Camera2",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_558);
    puVar17 = FUN_180006c00((longlong *)pmVar15,plVar13);
    local_7c0 = (vector<int,class_std::allocator<int>_> *)(puVar17 + 0xf);
    FUN_18000c8d0(&local_558);
    lVar24 = *param_1;
    local_538 = 0;
    uStack_530 = 0;
    local_528 = 0;
    uStack_520 = 0;
    FUN_18000c1d0(&local_538,"Camera1",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_538);
    puVar18 = FUN_180006c00((longlong *)pmVar15,plVar13);
    pvVar2 = (vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *)(puVar18 + 0xc);
    FUN_18000c8d0(&local_538);
    lVar24 = *param_1;
    local_518 = 0;
    uStack_510 = 0;
    local_508 = 0;
    uStack_500 = 0;
    FUN_18000c1d0(&local_518,"Camera2",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_518);
    puVar19 = FUN_180006c00((longlong *)pmVar15,plVar13);
    local_7c8 = (vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *)(puVar19 + 0xc);
    FUN_18000c8d0(&local_518);
    lVar24 = *param_1;
    local_4f8 = 0;
    uStack_4f0 = 0;
    local_4e8 = 0;
    uStack_4e0 = 0;
    FUN_18000c1d0(&local_4f8,"Camera1",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_4f8);
    puVar19 = FUN_180006c00((longlong *)pmVar15,plVar13);
    pvVar3 = (vector<class_cv::Mat,class_std::allocator<class_cv::Mat>_> *)(puVar19 + 9);
    FUN_18000c8d0(&local_4f8);
    lVar24 = *param_1;
    local_4d8 = 0;
    uStack_4d0 = 0;
    local_4c8 = 0;
    uStack_4c0 = 0;
    FUN_18000c1d0(&local_4d8,"Camera2",7);
    plVar13 = FUN_1800f7eb0((longlong *)(lVar24 + 0x2c8),&local_4d8);
    puVar20 = FUN_180006c00((longlong *)pmVar15,plVar13);
    local_208[0] = (vector<class_cv::Mat,class_std::allocator<class_cv::Mat>_> *)(puVar20 + 9);
    FUN_18000c8d0(&local_4d8);
    local_218 = (longlong *)0x0;
    lStack_210 = 0;
    local_218 = (longlong *)FUN_1801327e0(0x28);
    *local_218 = (longlong)local_218;
    local_218[1] = (longlong)local_218;
    local_218[2] = (longlong)local_218;
    *(undefined2 *)(local_218 + 3) = 0x101;
    local_228 = (longlong *)0x0;
    lStack_220 = 0;
    local_228 = (longlong *)FUN_1801327e0(0x28);
    *local_228 = (longlong)local_228;
    local_228[1] = (longlong)local_228;
    local_228[2] = (longlong)local_228;
    *(undefined2 *)(local_228 + 3) = 0x101;
    Libraries::Core::filterMissingFrame
              (pvVar1,(vector<int,class_std::allocator<int>_> *)(puVar17 + 0xf),
               (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                *)&local_218,
               (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                *)&local_228);
    if (lStack_210 != 0) {
      plVar13 = FUN_1800014c0();
      local_638 = 0;
      uStack_630 = 0;
      local_628 = 0;
      local_620 = 0;
      FUN_18000c1d0(&local_638,"[Wait.For.Shot] Detect skip frame from MASTER camera.",0x35);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_638,2,'\x01');
      plVar13 = (longlong *)*local_218;
      cVar5 = *(char *)((longlong)plVar13 + 0x19);
      while (cVar5 == '\0') {
        plVar21 = FUN_1800014c0();
        pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  cv::format(local_368,
                             "[Wait.For.Shot] Master at buffer_index %d detect %d skipped frame.",
                             (ulonglong)*(uint *)((longlong)plVar13 + 0x1c),
                             (ulonglong)*(uint *)(plVar13 + 4));
        FUN_180084c00(plVar21,pbVar22,2,'\x01');
        plVar21 = (longlong *)plVar13[2];
        if (*(char *)((longlong)plVar21 + 0x19) == '\0') {
          cVar5 = *(char *)(*plVar21 + 0x19);
          plVar13 = plVar21;
          plVar21 = (longlong *)*plVar21;
          while (cVar5 == '\0') {
            cVar5 = *(char *)(*plVar21 + 0x19);
            plVar13 = plVar21;
            plVar21 = (longlong *)*plVar21;
          }
        }
        else {
          cVar5 = *(char *)(plVar13[1] + 0x19);
          plVar9 = (longlong *)plVar13[1];
          plVar21 = plVar13;
          while ((plVar13 = plVar9, cVar5 == '\0' && (plVar21 == (longlong *)plVar13[2]))) {
            cVar5 = *(char *)(plVar13[1] + 0x19);
            plVar9 = (longlong *)plVar13[1];
            plVar21 = plVar13;
          }
        }
        cVar5 = *(char *)((longlong)plVar13 + 0x19);
      }
    }
    if (lStack_220 != 0) {
      plVar13 = FUN_1800014c0();
      local_618 = 0;
      uStack_610 = 0;
      local_608 = 0;
      local_600 = 0;
      FUN_18000c1d0(&local_618,"[Wait.For.Shot] Detect skip frame from SLAVE camera.",0x34);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_618,2,'\x01');
      plVar13 = (longlong *)*local_228;
      cVar5 = *(char *)((longlong)plVar13 + 0x19);
      while (cVar5 == '\0') {
        plVar21 = FUN_1800014c0();
        pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  cv::format(local_348,
                             "[Wait.For.Shot] Slave at buffer_index %d detect %d skipped frames.",
                             (ulonglong)*(uint *)((longlong)plVar13 + 0x1c),
                             (ulonglong)*(uint *)(plVar13 + 4));
        FUN_180084c00(plVar21,pbVar22,2,'\x01');
        plVar21 = (longlong *)plVar13[2];
        if (*(char *)((longlong)plVar21 + 0x19) == '\0') {
          cVar5 = *(char *)(*plVar21 + 0x19);
          plVar13 = plVar21;
          plVar21 = (longlong *)*plVar21;
          while (cVar5 == '\0') {
            cVar5 = *(char *)(*plVar21 + 0x19);
            plVar13 = plVar21;
            plVar21 = (longlong *)*plVar21;
          }
        }
        else {
          cVar5 = *(char *)(plVar13[1] + 0x19);
          plVar9 = (longlong *)plVar13[1];
          plVar21 = plVar13;
          while ((plVar13 = plVar9, cVar5 == '\0' && (plVar21 == (longlong *)plVar13[2]))) {
            cVar5 = *(char *)(plVar13[1] + 0x19);
            plVar9 = (longlong *)plVar13[1];
            plVar21 = plVar13;
          }
        }
        cVar5 = *(char *)((longlong)plVar13 + 0x19);
      }
    }
    pIVar6 = (Interface *)*param_1;
    local_7ce[0] = false;
    local_778[0] = 0;
    local_778[1] = 0;
    local_778[2] = 0;
    local_778[3] = 0;
    FUN_18000c1d0(local_778,"Configurations.Process.EraseDetectedMissingFrame",0x30);
    bVar10 = Libraries::Core::Parameters::exist
                       ((Parameters *)(pIVar6 + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_778);
    if (bVar10) {
      pPVar23 = Libraries::Core::Parameters::get
                          ((Parameters *)(pIVar6 + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_778);
      bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
    }
    else {
      pPVar23 = Libraries::Core::Parameters::get
                          ((Parameters *)(pIVar6 + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_778);
      Libraries::Core::Parameter::setValue(pPVar23,local_7ce);
      pPVar23 = Libraries::Core::Parameters::get
                          ((Parameters *)(pIVar6 + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_778);
      bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
      GolfIn::Interface::saveParameters(pIVar6);
    }
    FUN_18000c8d0(local_778);
    if ((bVar10 != false) && ((lStack_210 != 0 || (lStack_220 != 0)))) {
      plVar13 = FUN_1800014c0();
      local_5f8 = 0;
      uStack_5f0 = 0;
      local_5e8 = 0;
      local_5e0 = 0;
      FUN_18000c1d0(&local_5f8,"[Wait.For.Shot] Erasing skipped frame from frame number list...",
                    0x3f);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_5f8,2,'\x01');
      pvVar8 = local_7c0;
      Libraries::Core::eraseMissingFrames<int>
                (pvVar1,local_7c0,
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_218,
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_228);
      plVar13 = FUN_1800014c0();
      local_5d8 = 0;
      uStack_5d0 = 0;
      local_5c8 = 0;
      local_5c0 = 0;
      FUN_18000c1d0(&local_5d8,"[Wait.For.Shot] Erasing skipped frame from timestamp list...",0x3c);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_5d8,2,'\x01');
      Libraries::Core::eraseMissingFrames<unsigned___int64>
                (pvVar2,local_7c8,
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_218,
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_228);
      plVar13 = FUN_1800014c0();
      local_6f8 = 0;
      uStack_6f0 = 0;
      local_6e8 = 0;
      local_6e0 = 0;
      FUN_18000c1d0(&local_6f8,"[Wait.For.Shot] Erasing skipped frame from images buffer...",0x3b);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_6f8,2,'\x01');
      Libraries::Core::eraseMissingFrames<class_cv::Mat>
                (pvVar3,local_208[0],
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_218,
                 (map<int,int,struct_std::less<int>,class_std::allocator<struct_std::pair<int_const_,int>_>_>
                  *)&local_228);
      plVar13 = FUN_1800014c0();
      pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                cv::format(local_328,"[Wait.For.Shot] Setup new buffer size of: %d",
                           puVar16[0x10] - *(longlong *)pvVar1 >> 2);
      FUN_180084c00(plVar13,pbVar22,2,'\x01');
      lVar24 = puVar16[0x10] - *(longlong *)pvVar1 >> 2;
      if ((puVar19[10] - *(longlong *)pvVar3) / 0x60 + lVar24 +
          (puVar18[0xd] - *(longlong *)pvVar2 >> 3) != lVar24 * 3) {
        plVar13 = FUN_1800014c0();
        pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  cv::format(local_308,
                             "[Wait.For.Shot] One list is not setup at the correct size of: %d. Resizing to the minimum"
                             ,puVar16[0x10] - *(longlong *)pvVar1 >> 2);
        FUN_180084c00(plVar13,pbVar22,2,'\x01');
        iVar28 = (int)(puVar16[0x10] - *(longlong *)pvVar1 >> 2);
        iVar11 = (int)(puVar18[0xd] - *(longlong *)pvVar2 >> 3);
        if (iVar11 < iVar28) {
          iVar28 = iVar11;
        }
        iVar11 = (int)((puVar19[10] - *(longlong *)pvVar3) / 0x60);
        if (iVar11 < iVar28) {
          iVar28 = iVar11;
        }
        uVar14 = (ulonglong)iVar28;
        FUN_180009fc0((longlong *)pvVar1,uVar14);
        FUN_180009fc0((longlong *)pvVar8,uVar14);
        FUN_18000a210((longlong *)pvVar2,uVar14);
        FUN_18000a210((longlong *)local_7c8,uVar14);
        FUN_1800064a0((longlong *)pvVar3,uVar14);
        FUN_1800064a0((longlong *)local_208[0],uVar14);
      }
      plVar13 = (longlong *)**(longlong **)pmVar15;
      cVar5 = *(char *)((longlong)plVar13 + 0x19);
      while (cVar5 == '\0') {
        *(int *)(plVar13 + 0x1d) = (int)((plVar13[10] - plVar13[9]) / 0x60);
        plVar21 = (longlong *)plVar13[2];
        if (*(char *)((longlong)plVar21 + 0x19) == '\0') {
          cVar5 = *(char *)(*plVar21 + 0x19);
          plVar13 = plVar21;
          plVar21 = (longlong *)*plVar21;
          while (cVar5 == '\0') {
            cVar5 = *(char *)(*plVar21 + 0x19);
            plVar13 = plVar21;
            plVar21 = (longlong *)*plVar21;
          }
        }
        else {
          cVar5 = *(char *)(plVar13[1] + 0x19);
          plVar9 = (longlong *)plVar13[1];
          plVar21 = plVar13;
          while ((plVar13 = plVar9, cVar5 == '\0' && (plVar21 == (longlong *)plVar13[2]))) {
            cVar5 = *(char *)(plVar13[1] + 0x19);
            plVar9 = (longlong *)plVar13[1];
            plVar21 = plVar13;
          }
        }
        cVar5 = *(char *)((longlong)plVar13 + 0x19);
      }
      plVar13 = FUN_1800014c0();
      local_6d8 = 0;
      uStack_6d0 = 0;
      local_6c8 = 0;
      local_6c0 = 0;
      FUN_18000c1d0(&local_6d8,"[Wait.For.Shot] Skipped frame erased.",0x25);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_6d8,2,'\x01');
    }
    FUN_1800090b0((longlong *)&local_7c0);
    lVar24 = (longlong)local_7c0 - *(longlong *)param_1[1];
    plVar13 = FUN_1800014c0();
    puVar16 = FUN_180084840(local_2e8,lVar24 / 1000000);
    plVar21 = FUN_180007680(puVar16,0,"Time to grab frames for analysis: ",0x22);
    local_798 = *plVar21;
    lStack_790 = plVar21[1];
    local_788 = plVar21[2];
    lStack_780 = plVar21[3];
    plVar21[3] = 0xf;
    plVar21[2] = 0;
    *(undefined1 *)plVar21 = 0;
    plVar21 = FUN_18000a490(&local_798,&DAT_180175efc,4);
    local_718 = *plVar21;
    lStack_710 = plVar21[1];
    local_708 = plVar21[2];
    lStack_700 = plVar21[3];
    plVar21[2] = 0;
    plVar21[3] = 0xf;
    *(undefined1 *)plVar21 = 0;
    FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_718,1,'\x01');
    FUN_18000c8d0(&local_798);
    FUN_18000c8d0(local_2e8);
    if (pmVar15 ==
        (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
         *)0x0) {
      plVar13 = FUN_1800014c0();
      local_798 = 0;
      lStack_790 = 0;
      local_788 = 0;
      lStack_780 = 0;
      FUN_18000c1d0(&local_798,"[Wait.For.Shot] WaitForShot >> Frame Not Found !! ",0x32);
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_798,3,'\x01');
      FUN_180042ba0((longlong *)&local_228);
      uVar14 = FUN_180042ba0((longlong *)&local_218);
      uVar14 = uVar14 & 0xffffffffffffff00;
    }
    else {
      GolfIn::Interface::SendKeyBringProcessForeground((Interface *)*param_1);
      local_208[0] = (vector<class_cv::Mat,class_std::allocator<class_cv::Mat>_> *)
                     _time64((__time64_t *)0x0);
      ptVar25 = _localtime64((__time64_t *)local_208);
      local_3b0.tm_sec = ptVar25->tm_sec;
      local_3b0.tm_min = ptVar25->tm_min;
      local_3b0.tm_hour = ptVar25->tm_hour;
      local_3b0.tm_mday = ptVar25->tm_mday;
      local_3b0.tm_mon = ptVar25->tm_mon;
      local_3b0.tm_year = ptVar25->tm_year;
      local_3b0.tm_wday = ptVar25->tm_wday;
      local_3b0.tm_yday = ptVar25->tm_yday;
      local_3b0.tm_isdst = ptVar25->tm_isdst;
      memset(local_138,0,0xf8);
      FUN_180024950((basic_iostream<char,struct_std::char_traits<char>_> *)local_138);
      pcVar29 = "%Y_%m_%d_%H_%M_%S";
      Libraries::Core::formatDateTime(local_128,&local_3b0,"%Y_%m_%d_%H_%M_%S");
      FUN_1800240e0((longlong)local_120,(longlong *)local_158,pcVar29);
      *(undefined ***)((longlong)local_138 + (longlong)*(int *)(local_138[0] + 4)) =
           std::basic_stringstream<char,struct_std::char_traits<char>,class_std::allocator<char>_>::
           vftable;
      uVar27 = *(int *)(local_138[0] + 4) - 0x98;
      uVar14 = (ulonglong)uVar27;
      *(uint *)((longlong)local_138 + (longlong)*(int *)(local_138[0] + 4) + -4) = uVar27;
      FUN_180024890(local_120);
      std::basic_iostream<char,struct_std::char_traits<char>_>::
      ~basic_iostream<char,struct_std::char_traits<char>_>(local_118);
      std::basic_ios<char,struct_std::char_traits<char>_>::
      ~basic_ios<char,struct_std::char_traits<char>_>(local_a0);
      if (0x7fffffffffffffff - local_148 < 5) {
                    /* WARNING: Subroutine does not return */
        FUN_18000c940();
      }
      ppppuVar26 = local_158;
      if (0xf < local_140) {
        ppppuVar26 = (undefined8 ****)local_158[0];
      }
      FUN_18000bff0(local_388,uVar14,pcVar29,"Shot_",5,ppppuVar26,local_148);
      FUN_180009d70((longlong *)(*param_1 + 0x2e0),local_388);
      FUN_18000c8d0(local_388);
      pIVar6 = (Interface *)*param_1;
      local_4b8[0] = 0;
      local_4b8[1] = 0;
      local_4b8[2] = 0;
      local_4b8[3] = 0;
      FUN_18000c1d0(local_4b8,&DAT_18016a0f8,0);
      bVar10 = GolfIn::Interface::extractBallClub
                         (pIVar6,(Shot *)param_1[3],
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)(*param_1 + 0x2e0),pmVar15,
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_4b8);
      *(bool *)param_1[2] = bVar10;
      FUN_18000c8d0(local_4b8);
      if ((*(char *)param_1[2] != '\0') &&
         (PVar12 = GolfIn::Shot::getPlayerHanded((Shot *)param_1[3]), PVar12 != 0)) {
        GolfIn::Interface::computeBallImpactOnClub
                  ((Interface *)*param_1,(Shot *)param_1[3],
                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                   ((Interface *)*param_1 + 0x2e0),pmVar15);
      }
      pIVar6 = (Interface *)*param_1;
      local_7d0 = false;
      local_758[0] = 0;
      local_758[1] = 0;
      local_758[2] = 0;
      local_758[3] = 0;
      FUN_18000c1d0(local_758,"Configurations.Process.UseMLForBackSpinAndSideSpin",0x32);
      bVar10 = Libraries::Core::Parameters::exist
                         ((Parameters *)(pIVar6 + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_758);
      if (bVar10) {
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_758);
        bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
      }
      else {
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_758);
        Libraries::Core::Parameter::setValue(pPVar23,&local_7d0);
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_758);
        bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
        GolfIn::Interface::saveParameters(pIVar6);
      }
      FUN_18000c8d0(local_758);
      if ((*(char *)param_1[2] != '\0') && (bVar10 != false)) {
        GolfIn::Interface::compute_back_and_side_spin((Interface *)*param_1,(Shot *)param_1[3]);
      }
      GolfIn::Interface::OnCameraStateChanged((Interface *)*param_1,0);
      plVar13 = FUN_1800090b0(&local_478);
      lVar24 = *plVar13;
      lVar7 = *(longlong *)param_1[1];
      plVar13 = FUN_1800014c0();
      puVar16 = FUN_180084840(local_2c8,(lVar24 - lVar7) / 1000000);
      plVar21 = FUN_180007680(puVar16,0,"[Wait.For.Shot] Time to extract the shot: ",0x2a);
      local_6b8 = *plVar21;
      lStack_6b0 = plVar21[1];
      local_6a8 = plVar21[2];
      lStack_6a0 = plVar21[3];
      plVar21[3] = 0xf;
      plVar21[2] = 0;
      *(undefined1 *)plVar21 = 0;
      plVar21 = FUN_18000a490(&local_6b8,&DAT_180175efc,4);
      local_7b8 = *plVar21;
      lStack_7b0 = plVar21[1];
      local_7a8 = plVar21[2];
      lStack_7a0 = plVar21[3];
      plVar21[2] = 0;
      plVar21[3] = 0xf;
      *(undefined1 *)plVar21 = 0;
      FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_7b8,1,'\x01');
      FUN_18000c8d0(&local_6b8);
      FUN_18000c8d0(local_2c8);
      if (*(char *)param_1[2] != '\0') {
        this = (ShotData *)GolfIn::Shot::GetData((Shot *)param_1[3]);
        local_498 = 0;
        uStack_490 = 0;
        local_488 = 0;
        uStack_480 = 0;
        FUN_18000c1d0(&local_498,"Shot Properties",0xf);
        GolfIn::ShotData::print
                  (this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_498);
        FUN_18000c8d0(&local_498);
        local_2a8 = GolfIn::ShotData::vftable;
        FUN_18000c8d0(local_250);
        FUN_18000c8d0(local_270);
        uStack_1d0 = 0;
        local_1c8 = _DAT_18017ef00;
        uStack_1c0 = _UNK_18017ef08;
        local_1d8 = 0;
        uStack_190 = 0;
        local_188 = _DAT_18017ef00;
        uStack_180 = _UNK_18017ef08;
        local_198 = 0;
        uStack_170 = 0;
        local_168 = _DAT_18017ef00;
        uStack_160 = _UNK_18017ef08;
        local_178 = 0;
        GolfIn::Interface::CopyCamShotToGICTShot
                  ((Interface *)*param_1,(Shot *)param_1[3],(GICTSShotData *)&local_1f8);
        plVar13 = FUN_1800014c0();
        local_698 = 0;
        uStack_690 = 0;
        local_688 = 0;
        local_680 = 0;
        FUN_18000c1d0(&local_698,"[Wait.For.Shot] Calling on new shot...",0x26);
        FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_698,1,'\x01');
        pIVar6 = (Interface *)*param_1;
        local_7d8 = (code *)&local_450;
        local_450 = local_1f8;
        uStack_448 = uStack_1f0;
        local_440 = local_1e8;
        local_43c = local_1e4;
        local_438 = local_1e0;
        FUN_18000cb00(local_430,&local_1d8);
        local_410 = local_1b8;
        uStack_408 = uStack_1b0;
        local_400 = local_1a8;
        local_3fc = local_1a4;
        local_3f8 = local_1a0;
        local_3f4 = local_19c;
        FUN_18000cb00(local_3f0,&local_198);
        FUN_18000cb00(local_3d0,&local_178);
        GolfIn::Interface::OnNewShot(pIVar6,&local_450);
        FUN_18000c8d0(&local_178);
        FUN_18000c8d0(&local_198);
        FUN_18000c8d0(&local_1d8);
      }
      lVar24 = *param_1;
      if (*(char *)(lVar24 + 0x300) != '\0') {
        lVar7 = *(longlong *)(lVar24 + 0x7f0);
        if ((lVar7 != 0) &&
           ((*(char *)(lVar24 + 0x7f8) == '\0' || (*(char *)(lVar7 + 0xb8) == '\0')))) {
          FUN_180084940((longlong *)(lVar24 + 0x7f0));
        }
        plVar13 = FUN_1800014c0();
        local_678 = 0;
        uStack_670 = 0;
        local_668 = 0;
        local_660 = 0;
        FUN_18000c1d0(&local_678,"[Wait.For.Shot] Starting task saveShot...",0x29);
        FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_678,1,'\x01');
        local_7c8 = (vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *)
                    GolfIn::Interface::saveShot;
        plVar13 = FUN_1800f9f60(local_470,GolfIn::Interface::saveShot,&local_7c8,param_1,
                                (undefined8 *)(*param_1 + 0x2e0),param_1[3],(longlong *)pmVar15);
        lVar24 = *param_1;
        plVar21 = (longlong *)(lVar24 + 0x7f0);
        if (plVar21 != plVar13) {
          puVar16 = (undefined8 *)*plVar21;
          if (puVar16 != (undefined8 *)0x0) {
            LOCK();
            piVar4 = (int *)(puVar16 + 1);
            iVar28 = *piVar4;
            *piVar4 = *piVar4 + -1;
            UNLOCK();
            if (iVar28 == 1) {
              puVar17 = (undefined8 *)puVar16[0x19];
              if (puVar17 == (undefined8 *)0x0) {
                (**(code **)*puVar16)(puVar16,1);
              }
              else {
                (**(code **)*puVar17)(puVar17,puVar16);
              }
            }
          }
          lVar7 = *plVar13;
          *plVar13 = 0;
          *plVar21 = lVar7;
          *(char *)(lVar24 + 0x7f8) = (char)plVar13[1];
        }
        if (local_470[0] != (undefined8 *)0x0) {
          LOCK();
          piVar4 = (int *)(local_470[0] + 1);
          iVar28 = *piVar4;
          *piVar4 = *piVar4 + -1;
          UNLOCK();
          if (iVar28 == 1) {
            puVar16 = (undefined8 *)local_470[0][0x19];
            if (puVar16 == (undefined8 *)0x0) {
              (**(code **)*local_470[0])(local_470[0],1);
            }
            else {
              (**(code **)*puVar16)(puVar16,local_470[0]);
            }
          }
        }
      }
      pIVar6 = (Interface *)*param_1;
      local_7cf = true;
      local_738[0] = 0;
      local_738[1] = 0;
      local_738[2] = 0;
      local_738[3] = 0;
      FUN_18000c1d0(local_738,"Configurations.Debug.ExportPostShotVideo",0x28);
      bVar10 = Libraries::Core::Parameters::exist
                         ((Parameters *)(pIVar6 + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_738);
      if (bVar10) {
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_738);
        bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
      }
      else {
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_738);
        Libraries::Core::Parameter::setValue(pPVar23,&local_7cf);
        pPVar23 = Libraries::Core::Parameters::get
                            ((Parameters *)(pIVar6 + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_738);
        bVar10 = Libraries::Core::Parameter::toBoolean(pPVar23);
        GolfIn::Interface::saveParameters(pIVar6);
      }
      FUN_18000c8d0(local_738);
      if ((bVar10 != false) && (*(char *)param_1[2] != '\0')) {
        plVar13 = (longlong *)(*param_1 + 0x800);
        lVar24 = *plVar13;
        if ((lVar24 != 0) &&
           ((*(char *)(*param_1 + 0x808) == '\0' || (*(char *)(lVar24 + 0xb8) == '\0')))) {
          FUN_180084940(plVar13);
        }
        plVar13 = FUN_1800014c0();
        local_658 = 0;
        uStack_650 = 0;
        local_648 = 0;
        local_640 = 0;
        FUN_18000c1d0(&local_658,"[Wait.For.Shot] Starting task exportPostShot...",0x2f);
        FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_658,1,'\x01');
        local_7d8 = GolfIn::Interface::exportPostShot;
        plVar13 = FUN_1800f9f60(local_460,GolfIn::Interface::exportPostShot,&local_7d8,param_1,
                                (undefined8 *)(*param_1 + 0x2e0),param_1[3],(longlong *)pmVar15);
        lVar24 = *param_1;
        plVar21 = (longlong *)(lVar24 + 0x800);
        if (plVar21 != plVar13) {
          puVar16 = (undefined8 *)*plVar21;
          if (puVar16 != (undefined8 *)0x0) {
            LOCK();
            piVar4 = (int *)(puVar16 + 1);
            iVar28 = *piVar4;
            *piVar4 = *piVar4 + -1;
            UNLOCK();
            if (iVar28 == 1) {
              puVar17 = (undefined8 *)puVar16[0x19];
              if (puVar17 == (undefined8 *)0x0) {
                (**(code **)*puVar16)(puVar16,1);
              }
              else {
                (**(code **)*puVar17)(puVar17,puVar16);
              }
            }
          }
          lVar7 = *plVar13;
          *plVar13 = 0;
          *plVar21 = lVar7;
          *(char *)(lVar24 + 0x808) = (char)plVar13[1];
        }
        if (local_460[0] != (undefined8 *)0x0) {
          LOCK();
          piVar4 = (int *)(local_460[0] + 1);
          iVar28 = *piVar4;
          *piVar4 = *piVar4 + -1;
          UNLOCK();
          if (iVar28 == 1) {
            puVar16 = (undefined8 *)local_460[0][0x19];
            if (puVar16 == (undefined8 *)0x0) {
              (**(code **)*local_460[0])(local_460[0],1);
            }
            else {
              (**(code **)*puVar16)(puVar16,local_460[0]);
            }
          }
        }
      }
      FUN_18000c8d0((longlong *)local_158);
      FUN_180042ba0((longlong *)&local_228);
      uVar14 = FUN_180042ba0((longlong *)&local_218);
    }
  }
  else {
    plVar13 = FUN_1800014c0();
    local_7b8 = 0;
    lStack_7b0 = 0;
    local_7a8 = 0;
    lStack_7a0 = 0;
    FUN_18000c1d0(&local_7b8,"Wait.For.Shot >> Unable to load configuration file.",0x33);
    uVar14 = FUN_180084c00(plVar13,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)&local_7b8,3,'\x01');
    uVar14 = uVar14 & 0xffffffffffffff00;
  }
  return uVar14;
}

