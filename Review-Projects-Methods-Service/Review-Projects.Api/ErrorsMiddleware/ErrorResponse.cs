﻿namespace Review_Projects.Api.ErrorsMiddleware;

public class ErrorResponse
{
    public ErrorResponse(string traceId, List<ErroDetalhes> erros)
    {
        TraceId = Guid.NewGuid().ToString();
        Erros = erros;
    }

    public ErrorResponse(string logref, string message)
    {
        TraceId = Guid.NewGuid().ToString();
        Erros = new List<ErroDetalhes>();
        AddError(logref, message);
    }

    public string TraceId { get; private set; }
    public List<ErroDetalhes> Erros { get; private set; }

    public class ErroDetalhes
    {
        public ErroDetalhes(string logref, string message)
        {
            Logref = logref;
            Message = message;
        }

        public string Logref { get; private set; }
        public string Message { get; private set; }
    }

    public void AddError(string logref, string message)
    {
        Erros.Add(new ErroDetalhes(logref, message));
    }
}

