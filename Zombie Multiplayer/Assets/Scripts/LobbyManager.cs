using Photon.Pun; // 유니티용 포톤 컴포넌트들
using Photon.Realtime; // 포톤 서비스 관련 라이브러리
using UnityEngine;
using UnityEngine.UI;

// 마스터(매치 메이킹) 서버와 룸 접속을 담당
public class LobbyManager : MonoBehaviourPunCallbacks {
    private string gameVersion = "1.0.0"; // 게임 버전

    public Text connectionInfoText; // 네트워크 정보를 표시할 텍스트
    public Button joinButton; // 룸 접속 버튼

    // 게임 실행과 동시에 마스터 서버 접속 시도
    private void Start()
    {
        //접속에 필요한 정보 설정
        PhotonNetwork.GameVersion = gameVersion;

        // 설정한 정보로 마스터 서버 접속 시도
        PhotonNetwork.ConnectUsingSettings();

        // 룸 접속 버튼 잠시 비활성화
        joinButton.interactable = false;

        // 접속 시도 중 임을 텍스트로 표시
        connectionInfoText.text = "Connect to master server ...";
    }

    // 마스터 서버 접속 성공시 자동 실행
    public override void OnConnectedToMaster()
    {
        // 룸 접속 버튼 활성화
        joinButton.interactable = true;

        // 접속 정보 표시하기
        connectionInfoText.text = "Online: Connected to mater server succeed";
    }

    // 마스터 서버 접속 실패시 자동 실행
    public override void OnDisconnected(DisconnectCause cause)
    {
        
    }

    // 룸 접속 시도
    public void Connect() {
        
    }

    // (빈 방이 없어)랜덤 룸 참가에 실패한 경우 자동 실행
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        
    }

    // 룸에 참가 완료된 경우 자동 실행
    public override void OnJoinedRoom()
    {
        
    }
}