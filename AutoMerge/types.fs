namespace AutoMerge

module DomainTypes =

    type Ref =
        {
            id: string;
            name: string;
            hash: string;
            message: string
        }

    type Repository =
        {
            id: string
            name: string;
            permission: string;
            ref: Ref;
        }

    type MergeResult =
        {
            hash: string;
            url: string
            message: string
        }

    type UpdateRefResult =
        {
            hash: string;
            url: string;
        }

    type GitHubError =
        {
            type: string;
            message: string;
        }