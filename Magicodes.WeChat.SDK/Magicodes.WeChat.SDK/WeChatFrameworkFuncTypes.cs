﻿// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : WeChatFrameworkFuncTypes.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 16:33
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

namespace Magicodes.WeChat.SDK
{
    /// <summary>
    ///     方法类型
    /// </summary>
    public enum WeChatFrameworkFuncTypes
    {
        /// <summary>
        ///     根据Key获取微信配置
        /// </summary>
        Config_GetWeChatConfigByKey = 0,

        /// <summary>
        ///     模板消息发送
        /// </summary>
        APIFunc_TemplateMessageApi_Create = 1,

        /// <summary>
        ///     创建二维码
        /// </summary>
        APIFunc_QRCodeApi_Create = 2,

        /// <summary>
        ///     获取微信支付信息
        /// </summary>
        Config_GetWeChatPayConfigByKey = 3
    }
}