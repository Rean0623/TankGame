# TankGame
プログラミング未経験から3か月で一人で制作した、Unity製の戦車バトルゲームです。
初心者から完成作品までの過程をまとめた作品です。

## 概要
Unityで制作したシングルプレイの戦車バトルゲームです。戦闘、スコア管理、設定機能を備えています。
C#の学習カリキュラムを修了し、Unity開発に移行してから初めて完成させた作品です。

## 機能
- プレイヤーと敵のHPバー、シールドシステム
- 武器の取得システム
- カメラ追従
- ミニマップ表示
- スコアとタイムの計測、PlayerPrefsを使った永続的なランキング
- ゲームクリア / ゲームオーバー画面
- BGM / SEの音量スライダー付き設定パネル
- シングルトンのSoundManager（DontDestroyOnLoad）によるシーン間のBGM維持
- Unity IMGUIで構築したUI

## 使用技術
- Unity 6
- C#
- Rigidbodyによる物理ベースの移動

## 更新履歴
### v1.1
- ファイル名とC#スクリプト名を日本語に統一
- プレイヤーの弾の射程が長すぎる問題を修正
- プレイヤーと敵戦車のHPを調整
- 回復アイテムの回復量を調整
- ミニマップのサイズ比率を修正
- ランキングの順位表示のバグを修正

## 学んだこと
- シングルトンパターンを使った、シーンをまたぐゲーム状態（スコア、設定、音声）の管理
- Unity特有の問題のデバッグ：最大HPの競合状態、自傷ダメージのタグ判定バグ、リトライ時のTime.timeScaleのリセット、IMGUIの座標系、カーソルロックの挙動
- 先輩エンジニアのフィードバックを受けた、物理的に正しい移動処理への変更
  （Transform.TranslateからRigidbody.MovePosition / MoveRotationへ）

## プレイ
itch.io: https://rean0623.itch.io/tankgame
GitHub Releases: https://github.com/Rean0623/TankGame/releases/latest

<img width="2560" height="1600" alt="TankGame 2026_10_18 19_36_03" src="https://github.com/user-attachments/assets/d271ea33-8f93-4f67-bac6-12349321d73f" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_35_39" src="https://github.com/user-attachments/assets/e6e325b7-7009-45d2-a541-ae958a6ff6c4" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_34_55" src="https://github.com/user-attachments/assets/13655c53-912e-4ce3-bb13-57d08f2325c3" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_34_00" src="https://github.com/user-attachments/assets/f67e4e19-66bc-4ccf-86c3-13a4acb5e327" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_57" src="https://github.com/user-attachments/assets/900ce12d-9150-49ad-ac03-e710ae5a5d48" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_52" src="https://github.com/user-attachments/assets/dbf4cf7b-4092-4026-a37b-cd4106e64363" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_35" src="https://github.com/user-attachments/assets/f10a15b6-7e69-446d-9e03-1087a9c88cb7" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_18" src="https://github.com/user-attachments/assets/0311de8d-9135-4f53-8abc-cf919e1eefab" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_32_47" src="https://github.com/user-attachments/assets/e93cdceb-eebb-45a8-b134-5e8e6479cac2" />
