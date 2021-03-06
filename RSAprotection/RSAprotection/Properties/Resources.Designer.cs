﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSAprotection.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RSAprotection.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   この文章が読めているということは、第二の扉も無事に通過したようですね。どんどん進んでください。最終章では複数の問題がありますが、あなたが解くべき問題は決められています。あなたが解くべき問題は、『あなたの誕生日』と『偽物の乱数』の組合せという理不尽な計算で決まります。これも何かの運命と思っていただき、見事計算を突破し、自分が挑む最終課題を発見してください。あなたの誕生日の月と日付をならべた４桁の整数をＭＭＤＤと表記します。ＭＭＤＤ以下の最大の素数をＫとします。例えば、７月１２日生まれの場合、整数ＭＭＤＤは０７１２。７１２以下の最大の素数Ｋは７０９ということになります。Ｋより１個小さい素数をＬ、さらにもう１個小さい素数をＭとします。以下の方法で、『あなたの誕生日』を種とする『偽物の乱数Ｙ（ｎ）』を生成してください。【数式１】　Ｙ（１）＝ＭＭＤＤ【数式２】　Ｙ（ｎ）＝ＭＯＤ（（Ｋ＋１）＊Ｙ（ｎ－１）＋Ｍ，Ｋ＊Ｌ）最終章の問題は全部で６問あります。そのため、Ｙ（ｎ）の各要素に対して、ＭＯＤ（Ｙ（ｎ），６）をとった系列Ｙ’（ｎ）を求め、０から５までの数字に変換します。【数式３】　Ｙ’（ｎ）＝｛ＭＯＤ（Ｙ（１），６），Ｍ [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string answer1 {
            get {
                return ResourceManager.GetString("answer1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string plaintext {
            get {
                return ResourceManager.GetString("plaintext", resourceCulture);
            }
        }
    }
}
