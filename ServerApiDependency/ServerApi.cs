﻿using ServerApiDependency.Enums;
using ServerApiDependency.Interface;
using ServerApiDependency.Utility;
using ServerApiDependency.Utility.CustomException;
using System;
using System.Net;

namespace ServerApiDependency
{
    public class ServerApi : IServerApi
    {
        public int CancelGame()
        {
            const string apiPage = "cancel.php";
            try
            {
                var response = PostToThirdParty(ApiType.CancelGame, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new ServerApiFailException();
                }
                return response;
            }
            catch (WebException e)
            {
                TiDebugHelper.Error($" WebException: {e}");
                SaveFailRequestToDb(ApiType.CancelGame, apiPage);
                throw e;
            }
        }

        public int GameResult()
        {
            const string apiPage = "result.php";
            try
            {
                var response = PostToThirdParty(ApiType.GameResult, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new ServerApiFailException();
                }
                return response;
            }
            catch (WebException e)
            {
                TiDebugHelper.Error($" WebException: {e}");
                SaveFailRequestToDb(ApiType.GameResult, apiPage);
                throw e;
            }
        }

        public int StartGame()
        {
            const string apiPage = "start.php";
            try
            {
                var response = PostToThirdParty(ApiType.StartGame, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new ServerApiFailException();
                }
                return response;
            }
            catch (WebException e)
            {
                TiDebugHelper.Error($" WebException: {e}");
                SaveFailRequestToDb(ApiType.StartGame, apiPage);
                throw e;
            }
        }

        /// <summary>
        /// treat this method is a dependency to connect to third-party server
        /// </summary>
        /// <param name="apiType">Type of the API.</param>
        /// <param name="apiPage">The API page.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private int PostToThirdParty(ApiType apiType, string apiPage)
        {
            // don't implement
            throw new NotImplementedException();
        }

        /// <summary>
        /// treat this method as a dependency to connect to db
        /// </summary>
        /// <param name="apiType">Type of the API.</param>
        /// <param name="apiPage">The API page.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void SaveFailRequestToDb(ApiType apiType, string apiPage)
        {
            // don't implement
            throw new NotImplementedException();
        }
    }
}