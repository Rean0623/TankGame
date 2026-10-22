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

### v1.2
- バグ修正

## 学んだこと
- シングルトンパターンを使った、シーンをまたぐゲーム状態（スコア、設定、音声）の管理
- Unity特有の問題のデバッグ：最大HPの競合状態、自傷ダメージのタグ判定バグ、リトライ時のTime.timeScaleのリセット、IMGUIの座標系、カーソルロックの挙動
- 先輩エンジニアのフィードバックを受けた、物理的に正しい移動処理への変更
  （Transform.TranslateからRigidbody.MovePosition / MoveRotationへ）

## プレイ
itch.io: https://rean0623.itch.io/tankgame
GitHub Releases: https://github.com/Rean0623/TankGame/releases/latest

## ゲーム写真
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_32_47" src="https://github.com/user-attachments/assets/c56a6df6-891b-4e6c-9d87-31b81fe7e100" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_18" src="https://github.com/user-attachments/assets/9d09dcce-f4cd-4817-b5d8-41f6e1b13222" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_35" src="https://github.com/user-attachments/assets/a24f6611-4392-48dd-b90c-898b55b5b3f8" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_52" src="https://github.com/user-attachments/assets/82561538-e2df-465b-908e-ce2b4dab3641" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_33_57" src="https://github.com/user-attachments/assets/ceb15add-74ec-464e-b25b-9361672db5da" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_34_00" src="https://github.com/user-attachments/assets/5ebb2f8f-a71e-44b5-b796-b91ce00bbf54" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_34_55" src="https://github.com/user-attachments/assets/8961cceb-1a21-468a-9c70-de712d8630bb" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_35_39" src="https://github.com/user-attachments/assets/a9fc34a1-e5d5-4bb9-bf85-c37e1d91d042" />
<img width="2560" height="1600" alt="TankGame 2026_10_18 19_36_03" src="https://github.com/user-attachments/assets/87643105-e317-42cf-b6a1-0d3d259a752d" />
