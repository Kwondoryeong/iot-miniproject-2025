using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMrpSimulatorApp.Helpers
{
    /// <summary>
    /// 프로젝트 내에서 공통으로 사용하는 정적 클래스
    /// 클래스 자체가 static 일 필요는 없음. 사용할 변수들이 static이어야 함!!
    /// 변수가 static 인 것이 더 중요
    /// </summary>
    public class Common
    {
        // DB연결 문자열
        public static readonly string CONNSTR = "Server=localhost;Database=miniproject;Uid=root;Password=12345;Charset=Utf8";

        // MahApps.Metro 다이얼로그 코디네이터 
        public static IDialogCoordinator DIALOGCOORDINATOR;
    }
}
