using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface IDislikeCommentCommand : ICommand<CommentLikeDto>
    {
    }
}
